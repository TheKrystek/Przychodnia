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
        public DodajPacjenta()
        {
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
    
    }
}
