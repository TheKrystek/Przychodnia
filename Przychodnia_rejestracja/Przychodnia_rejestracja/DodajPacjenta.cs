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
    public partial class DodajPacjenta : Form
    {

        int index;

        public DodajPacjenta(int id = -1)
        {
            this.index = id;
            InitializeComponent();
        }

        private void dodajPacjenta() {
            using (var dc = new EntitiesPrzychodnia())
            {
                var pacjent = new Pacjenci();
                pacjent.imie = imie.Text;
                pacjent.nazwisko = nazwisko.Text;

                try
                {
                    pacjent.data_urodzenia = this.dtpUrodzenia.Value;
                }
                catch
                {
                    MessageBox.Show("Błędny format daty - spróbuj jescze raz!");
                }
                pacjent.miejsce_urodzenia = miejsce_ur.Text;
                pacjent.miejsce_zamieszkania = miejsce_zam.Text;
                pacjent.PESEL = pesel.Text;
                pacjent.ulica = ulica.Text;
                pacjent.kod_pocztowy = kod.Text;
                pacjent.plec = (pacjent.imie.Substring(pacjent.imie.Length - 1, 1) == "a" ? "k" : "m");
                try
                {
                    dc.Pacjenci.Add(pacjent);
                    dc.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Nie udało się dodać rekordu");
                }
            }
        }

        private void edytujPacjenta()
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                var pacjent = dc.Pacjenci.Single(p => p.ID_Pacjenta == index);

                pacjent.imie = imie.Text;
                pacjent.nazwisko = nazwisko.Text;
                pacjent.data_urodzenia = this.dtpUrodzenia.Value;
                pacjent.miejsce_urodzenia = miejsce_ur.Text;
                pacjent.miejsce_zamieszkania = miejsce_zam.Text;
                pacjent.PESEL = pesel.Text;
                pacjent.ulica = ulica.Text;
                pacjent.kod_pocztowy = kod.Text;
                try
                {
                    dc.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Nie udało się zaktualizować rekordu");
                }
            }
        
        
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            dodajPacjenta();
            this.Close();
        }

        private void anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void validacja(object sender, EventArgs e)
        {
            aktywujZapisz();
        }

        void aktywujZapisz()
        {
            dodaj.Enabled = (
                Validacja.Tekst(imie.Text, true) &&
                Validacja.Tekst(nazwisko.Text, true) &&
                Validacja.Tekst(miejsce_ur.Text, true) &&
                Validacja.Tekst(miejsce_zam.Text, true) &&
                Validacja.Tekst(ulica.Text, false) &&
                Validacja.Kod(kod.Text) &&
                !String.IsNullOrEmpty(pesel.Text));
        }

        private void DodajPacjenta_Load(object sender, EventArgs e)
        {
            if (index > -1)
            {
                wypenijDanymi();
                ZamienMiejscami(dodaj, zapisz);
                this.Text = String.Format("Edytuj pacjenta - {0} {1}", imie.Text, nazwisko.Text);
            }

        }
        private void ZamienMiejscami(Control first, Control second)
        {
            if (first.Visible)
            {
                first.Hide();
                second.Show();
                second.Location = first.Location;
            }
            else
            {
                second.Hide();
                first.Show();
                first.Location = second.Location;
            }
        }

        public void wypenijDanymi()
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                var pacjent = from c in dc.Pacjenci
                             where c.ID_Pacjenta == this.index
                             select new
                             {
                                 imie = c.imie,
                                 nazwisko = c.nazwisko,
                                 miejsce_ur = c.miejsce_urodzenia,
                                 data_ur = c.data_urodzenia,
                                 id = c.ID_Pacjenta,
                                 miescje_zam = c.miejsce_zamieszkania,
                                 adres = c.ulica,
                                 kod_pocztowy = c.kod_pocztowy,
                                 pesel = c.PESEL
                             };

                this.imie.Text = pacjent.First().imie;
                this.nazwisko.Text = pacjent.First().nazwisko;
                this.dtpUrodzenia.Value = (DateTime)pacjent.First().data_ur;
                this.miejsce_ur.Text = pacjent.First().miejsce_ur;
                this.miejsce_zam.Text = pacjent.First().miescje_zam;
                this.ulica.Text = pacjent.First().adres;
                this.kod.Text = pacjent.First().kod_pocztowy;
                this.pesel.Text = pacjent.First().pesel;
            }
        }

    }
}
