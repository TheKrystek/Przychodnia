using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia_rejestracja
{
    public partial class Statystyki : Form
    {
        public Statystyki()
        {
            InitializeComponent();
        }

        private void pokaz_Click(object sender, EventArgs e)
        {
            if (lista.SelectedIndex > -1)
            {
                switch (lista.SelectedItem.ToString())
                {
                    case "Lekarze z największą liczbą wypisanych recept":
                        this.lekarzeZNajwiekszaLiczbaWypisanychRecept();
                        break;
                    case "Lekarze z największą sumą leków na receptach":
                        this.lekarzeZNajwiekszaSumaLekow();
                        break;
                    case "Lekarze z największą liczbą pacjentów":
                        this.lekarzeZNajwiekszaLiczbaPacjentow();
                        break;
                    case "Lekarze którzy wypisali recepty na więcej niż średnia": 
                        this.lekarzeZSumaReceptWiekszaNizSrednia();
                        break;
                    case "Lekarze wypisujący najdroższe leki":
                        this.lekarzeWypisujacyNajdrozszeLeki();
                        break;
                    case "Choroby i liczba zdiagnozowanych przypadków":
                        this.chorobyILiczbaIchDiagnoz();
                        break;
                    case "Najpopularniejsze choroby według miesięcy diagnozy":
                        this.najpopularniejszeChorobyWedlugMiesiecy();
                        break;
                    case "Pacjentki zbyt często odwiedzajace swoich lekarzy":
                        this.pacjentkiZbytCzestoOdwiedzajaceLekarzy();
                        break;
                    default:
                        break;
                }
            }  
        }
        void ustawStatus(string nazwa = "Wyników") {
            status.Text = String.Format("{0}: {1}",nazwa, output.RowCount);
        }
        void lekarzeZNajwiekszaLiczbaWypisanychRecept() {
            using (var dc = new EntitiesPrzychodnia())
            {
                var query = from l in dc.Lekarze
                              join w in dc.Wizyty on l.ID_Lekarza equals w.ID_Lekarza
                              join r in dc.Recepty on w.ID_Wizyty equals r.ID_Wizyty
                              group l by new { l.ID_Lekarza, l.imie, l.nazwisko } into g
                              orderby g.Key descending
                              select new
                              {
                                  imie = g.Key.imie,
                                  nazwisko = g.Key.nazwisko,
                                  liczba = g.Count()
                              };
                output.DataSource = query.ToList();
                ustawStatus();
            }
        }    
        void lekarzeZNajwiekszaSumaLekow() {
            using (var dc = new EntitiesPrzychodnia())
            {
                var query = from l in dc.Lekarze
                              join w in dc.Wizyty on l.ID_Lekarza equals w.ID_Lekarza
                              join r in dc.Recepty on w.ID_Wizyty equals r.ID_Wizyty
                              join le in dc.Lekarstwa on r.ID_Lekarstwa equals le.ID_Lekarstwa
                              group new {l, le} by new {l.ID_Lekarza, l.imie, l.nazwisko } into g
                              let suma = g.Sum(x => x.le.cena)
                              orderby suma descending
                              select new
                              {
                                  imie = g.Key.imie,
                                  nazwisko = g.Key.nazwisko,
                                  suma = g.Sum(wynik => wynik.le.cena)
                              };
                output.DataSource = query.ToList();
                ustawStatus();
            }
        }
        void lekarzeZNajwiekszaLiczbaPacjentow() {
            using (var dc = new EntitiesPrzychodnia())
            {
                var query = from l in dc.Lekarze
                            join w in dc.Wizyty on l.ID_Lekarza equals w.ID_Lekarza
                            join p in dc.Pacjenci on w.ID_Pacjenta equals p.ID_Pacjenta
                            group l by new {l.ID_Lekarza, l.imie, l.nazwisko} into g
                            select new
                            {
                                imie = g.Key.imie,
                                nazwisko = g.Key.nazwisko,
                                liczba = g.Count()
                            };
                output.DataSource = query.ToList();
                ustawStatus();
            }
        }
        void lekarzeZSumaReceptWiekszaNizSrednia() {
            using (var dc = new EntitiesPrzychodnia())
            {
                var query = from l in dc.Lekarze
                            join w in dc.Wizyty on l.ID_Lekarza equals w.ID_Lekarza
                            join r in dc.Recepty on w.ID_Wizyty equals r.ID_Wizyty
                            join le in dc.Lekarstwa on r.ID_Lekarstwa equals le.ID_Lekarstwa
                            group new { l, le } by new { l.ID_Lekarza, l.imie, l.nazwisko } into g
                            let suma = g.Sum(x => x.le.cena)
                            let srednia = g.Average(x=>x.le.cena)
                            orderby suma descending
                            where suma > srednia
                            select new
                            {
                                imie = g.Key.imie,
                                nazwisko = g.Key.nazwisko,
                                suma = g.Sum(wynik => wynik.le.cena),
                                srednia = g.Average(wynik => wynik.le.cena),
                                roznica = suma - srednia
                            };
                output.DataSource = query.ToList();
                ustawStatus();
            }
        }
        void lekarzeWypisujacyNajdrozszeLeki() {
            using (var dc = new EntitiesPrzychodnia())
            {
                /*  
                 *  Wybieramy 10 najdroższych leków, a następnie szukamy lekarzy, którzy wypisali na nie recepty
                 * 
                 * SQL:
                 * select l.Imie, l.Nazwisko, le.nazwa, le.cena 
                 *      from Lekarze l 
                 *      join Wizyty w on l.ID_Lekarza = w.ID_Lekarza 
                 *      join Recepty r on w.ID_Wizyty = r.ID_Wizyty 
                 *      join Lekarstwa le on r.ID_Lekarstwa = le.ID_Lekarstwa 
                 *          where le.ID_Lekarstwa in 
                 *                  (select Top 10 ID_Lekarstwa from Lekarstwa order by cena DESC);
                 *
                 */
                var subquery = from le in dc.Lekarstwa 
                               orderby le.cena descending
                               select le;

                var query = from l in dc.Lekarze
                            join w in dc.Wizyty on l.ID_Lekarza equals w.ID_Lekarza
                            join r in dc.Recepty on w.ID_Wizyty equals r.ID_Wizyty
                            join le in dc.Lekarstwa on r.ID_Lekarstwa equals le.ID_Lekarstwa
                            where subquery.Take(10).Contains(le)
                            select new
                            {
                                imie_lekarza = l.imie,
                                nazwisko_lekarza = l.nazwisko,
                                nazwa_leku = le.nazwa,
                                cena_leku = le.cena
                            };

                output.DataSource = query.ToList();
                ustawStatus();
            }
        }
        void chorobyILiczbaIchDiagnoz() {
            using (var dc = new EntitiesPrzychodnia())
            {
                var query = from ch in dc.Choroby
                            join d in dc.Diagnozy on ch.ID_Choroby equals d.ID_Choroby
                            group ch by new {ch.ID_Choroby, ch.nazwa} into g
                            select new { 
                                nazwa_choroby = g.Key.nazwa,
                                suma = g.Count()
                            };
                output.DataSource = query.ToList();
                ustawStatus();
            }
        }
        void najpopularniejszeChorobyWedlugMiesiecy() {
            /*
             * SQL:
             *      select ch.nazwa, month(w.data) as 'miesiac', count(*) as 'liczba diagnoz' 
             *          from Diagnozy d 
             *          join Wizyty w on d.ID_Wizyty = w.ID_Wizyty 
             *          join Choroby ch on d.ID_Choroby = ch.ID_Choroby 
             *              group by ch.ID_Choroby, ch.nazwa, MONTH(w.data)       
             */
            using (var dc = new EntitiesPrzychodnia())
            {
                string[] miesiace = { "Styczeń", "Luty", "Marzec", "Kwiecień", "Maj", "Czerwiec", "Lipiec", "Sierpień", "Wrzesień", "Pazdźiernik", "Listopad", "Grudzień" };
                var query = from ch in dc.Choroby
                            join d in dc.Diagnozy on ch.ID_Choroby equals d.ID_Choroby
                            join w in dc.Wizyty on d.ID_Wizyty equals w.ID_Wizyty
                            group new {ch, w} by new { ch.ID_Choroby, ch.nazwa, w.data.Value.Month} into g
                            select new
                            {
                                nazwa_choroby = g.Key.nazwa,
                                miesiac = g.Key.Month,
                                suma = g.Count()
                            };

                output.DataSource = query.ToList();
                ustawStatus();
            }
        }
        void pacjentkiZbytCzestoOdwiedzajaceLekarzy() { 
          
                // Aby wyznaczyc srednia liczbe wizyt pacjentki u danego lekarza poslugujemy sie procedurą składowaną?
                // (stored procedure)
                
                double srednia = 

                var query = from l in dc.Lekarze
                            join w in dc.Wizyty on l.ID_Lekarza equals w.ID_Lekarza
                            join p in dc.Pacjenci on w.ID_Pacjenta equals p.ID_Pacjenta
                            group new { l, p } by new { 
                                    l.ID_Lekarza, 
                                    imie_lekarza = l.imie, 
                                    nazwisko_lekarza = l.nazwisko, 
                                    p.ID_Pacjenta,
                                    imie_pacjenta = p.imie, 
                                    nazwisko_pacjenta = p.nazwisko 
                                } into g
                            let suma = g.Average(x => x.sum)
                            let srednia = g.Average(x => x.le.cena)
                            orderby suma descending
                            where suma > srednia
                            select new
                            {
                                imie_ = g.Key.imie,
                                nazwisko = g.Key.nazwisko,
                                suma = g.Sum(wynik => wynik.le.cena),
                                srednia = g.Average(wynik => wynik.le.cena),
                                roznica = suma - srednia
                            };
                output.DataSource = query.ToList();
                ustawStatus();
            }
        }

    }
}
