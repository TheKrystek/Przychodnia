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
    public partial class DodajWizyte : Form
    {

        public DodajWizyte()
        {
            InitializeComponent();
            wczytajDaneLekarzy();
            wczytajDanePacjentow();
        }
        private void DodajWizyte_Load(object sender, EventArgs e)
        {

        }
        private void dodajWizyte() {
            using (var dc = new EntitiesPrzychodnia())
            {
                var pacjent = from p in dc.Pacjenci
                              where p.PESEL == this.pacjenciPESEL.Text
                              select new
                              {
                                  id = p.ID_Pacjenta
                              };

                var lekarz = from l in dc.Lekarze
                             where l.PESEL == this.lekarzePESEL.Text
                             select new
                             {
                                 id = l.ID_Lekarza
                             };


                var wizyta = new Wizyty();
                wizyta.czas = new TimeSpan(czas.Value.TimeOfDay.Hours, czas.Value.TimeOfDay.Minutes, 00);
                wizyta.data = data.Value;
                wizyta.ID_Lekarza = lekarz.First().id;
                wizyta.ID_Pacjenta = pacjent.First().id;

                try
                {
                    dc.Wizyty.Add(wizyta);
                    dc.SaveChanges();
                }
                catch { }
            }
        }
        private void dodaj_Click(object sender, EventArgs e)
        {
            dodajWizyte();
            this.Close();
        }
        private void anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pacjentNazwisko_SelectedValueChanged(object sender, EventArgs e)
        {
            wczytajDanePacjentow(pacjentNazwisko.SelectedItem.ToString());
            aktywujDodaj();
        }
        private void pacjentImie_SelectedValueChanged(object sender, EventArgs e)
        {
            wczytajDanePacjentow(pacjentNazwisko.SelectedItem.ToString(), pacjentImie.SelectedItem.ToString());
            aktywujDodaj();
        }
        private void lekarzNazwisko_SelectedValueChanged(object sender, EventArgs e)
        {
            wczytajDaneLekarzy(lekarzNazwisko.SelectedItem.ToString());
            aktywujDodaj();
        }
        private void lekarzImie_SelectedValueChanged(object sender, EventArgs e)
        {
            wczytajDaneLekarzy(lekarzNazwisko.SelectedItem.ToString(), lekarzImie.SelectedItem.ToString());
            aktywujDodaj();
        }
        private void aktywujDodaj() { 
            dodaj.Enabled = (
                lekarzImie.SelectedIndex >= 0 &&
                lekarzNazwisko.SelectedIndex >= 0 &&
                lekarzePESEL.SelectedIndex >= 0 &&
                pacjentImie.SelectedIndex >= 0 &&
                pacjentNazwisko.SelectedIndex >= 0 &&
                pacjenciPESEL.SelectedIndex >= 0
                );
        }
        private void wczytajDaneLekarzy(string nazwisko = "", string imie = "")
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                var lekarze = from c in dc.Lekarze
                              select new
                              {
                                  imie = c.imie,
                                  nazwisko = c.nazwisko,
                                  pesel = c.PESEL
                              };

                if (!String.IsNullOrEmpty(nazwisko))
                    lekarze = lekarze.Where(l => l.nazwisko == nazwisko);
                if (!String.IsNullOrEmpty(imie))
                    lekarze = lekarze.Where(l => l.imie == imie);

                List<String> imiona = new List<String>();
                List<String> nazwiska = new List<String>();
                List<String> pesele = new List<String>();
                foreach (var lekarz in lekarze)
                {
                    if (!imiona.Contains(lekarz.imie))
                        imiona.Add(lekarz.imie);

                    if (!nazwiska.Contains(lekarz.nazwisko))
                        nazwiska.Add(lekarz.nazwisko);

                    if (!pesele.Contains(lekarz.pesel))
                        pesele.Add(lekarz.pesel);
                }

                imiona.Sort();
                nazwiska.Sort();
                pesele.Sort();
                pesele.Distinct();
                
                if (String.IsNullOrEmpty(imie))
                {
                    lekarzImie.Items.Clear();
                    lekarzImie.Items.AddRange(imiona.ToArray());
                }

                if (lekarzImie.Items.Count == 1)
                    lekarzImie.SelectedIndex = 0;

                if (String.IsNullOrEmpty(nazwisko))
                    lekarzNazwisko.Items.AddRange(nazwiska.ToArray());

                lekarzePESEL.Items.Clear();
                lekarzePESEL.Items.AddRange(pesele.ToArray());
                if (lekarzePESEL.Items.Count == 1)
                    lekarzePESEL.SelectedIndex = 0;

            }
        }
        private void wczytajDanePacjentow(string nazwisko = "", string imie = "")
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                var pacjenci = from c in dc.Pacjenci
                              select new
                              {
                                  imie = c.imie,
                                  nazwisko = c.nazwisko,
                                  pesel = c.PESEL
                              };

                if (!String.IsNullOrEmpty(nazwisko))
                    pacjenci = pacjenci.Where(l => l.nazwisko == nazwisko);
                if (!String.IsNullOrEmpty(imie))
                    pacjenci = pacjenci.Where(l => l.imie == imie);

                List<String> imiona = new List<String>();
                List<String> nazwiska = new List<String>();
                List<String> pesele = new List<String>();
                foreach (var pacjent in pacjenci)
                {
                    if (!imiona.Contains(pacjent.imie))
                        imiona.Add(pacjent.imie);

                    if (!nazwiska.Contains(pacjent.nazwisko))
                        nazwiska.Add(pacjent.nazwisko);

                    if (!pesele.Contains(pacjent.pesel))
                        pesele.Add(pacjent.pesel);
                }

                imiona.Sort();
                nazwiska.Sort();
                pesele.Sort();

        
                pacjenciPESEL.Items.Clear();
                if (String.IsNullOrEmpty(imie))
                {

                    pacjentImie.Items.Clear();
                    pacjentImie.Items.AddRange(imiona.ToArray());
                }

                if (pacjentImie.Items.Count == 1)
                    pacjentImie.SelectedIndex = 0;

                if (String.IsNullOrEmpty(nazwisko))
                    pacjentNazwisko.Items.AddRange(nazwiska.ToArray());

                pacjenciPESEL.Items.AddRange(pesele.ToArray());
                if (pacjenciPESEL.Items.Count == 1)
                    pacjenciPESEL.SelectedIndex = 0;

            }
        }
        private void pacjenciPESEL_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktywujDodaj();
        }
        private void lekarzePESEL_SelectedIndexChanged(object sender, EventArgs e)
        {
            aktywujDodaj();
        }




    }
}
