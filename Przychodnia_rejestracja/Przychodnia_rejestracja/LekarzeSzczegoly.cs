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
    public partial class LekarzeSzczegoly : Form
    {
        private int index;

        public LekarzeSzczegoly(int i)
        {
            InitializeComponent();
            index = i;


            wypenijDanymi();
            wypenijDanymiSpecjalnosci();
            wypenijDanymiWizyty();
        }

        public void wypenijDanymi(){
            using (var dc = new EntitiesPrzychodnia())
            {
                var lekarz = from c in dc.Lekarze
                              where c.ID_Lekarza == this.index
                              select new
                              {
                                  imie = c.imie,
                                  nazwisko = c.nazwisko,
                                  miejsce_ur = c.miejsce_urodzenia,
                                  data_ur = c.data_urodzenia,
                                  id = c.ID_Lekarza,
                                  miescje_zam = c.miejsce_zamieszkania,
                                  adres = c.ulica,
                                  kod_pocztowy = c.kod_pocztowy
                              };

                this.imie.Text = lekarz.First().imie;
                this.nazwisko.Text = lekarz.First().nazwisko;
                this.data_ur.Text = lekarz.First().data_ur.ToString();
                this.miejsce_ur.Text = lekarz.First().miejsce_ur;
                this.miejsce_zam.Text = lekarz.First().miescje_zam;
                this.ulica.Text = lekarz.First().adres;
                this.kod.Text = lekarz.First().kod_pocztowy;
            }   
        }

        public void wypenijDanymiSpecjalnosci()
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                var specjalnosci = from ls in dc.LekarzSpecjalnosc
                                   join s in dc.Specjalnosci on ls.ID_Specjalnosci equals s.ID_Specjalnosci
                                   where ls.ID_Lekarza == this.index
                                   select new
                                   {
                                       specjalnosc = s.nazwa,
                                       data_nad = ls.data_nadania
                                   };
                dgvSpecjalnosci.DataSource = specjalnosci.ToList();
            }
        }

        public void wypenijDanymiWizyty()
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                var wizyty = from w in dc.Wizyty   
                                   where w.ID_Lekarza == this.index
                                   join p in dc.Pacjenci on w.ID_Pacjenta equals p.ID_Pacjenta
                                   orderby w.data descending , w.czas descending
                                   select new
                                   {
                                       data = w.data,
                                       godzina = w.czas,
                                       wimie = p.imie,
                                       wnazwisko = p.nazwisko, 
                                       odbyta = w.czy_odbyta
                                   };
                dgvWizyty.DataSource = wizyty.ToList();
            }
        }



    }
}
