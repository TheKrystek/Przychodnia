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
        public bool szczegoly = true;
        public LekarzeSzczegoly(int i)
        {
            InitializeComponent();
            index = i;

        }

        public void wypenijDanymi(){
            using (var dc = new EntitiesPrzychodnia()){
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
                                  kod_pocztowy = c.kod_pocztowy,
                                  pesel = c.PESEL
                              };

                this.imie.Text = lekarz.First().imie;
                this.nazwisko.Text = lekarz.First().nazwisko;
                this.dtpUrodzenia.Value = (DateTime)lekarz.First().data_ur;
                this.miejsce_ur.Text = lekarz.First().miejsce_ur;
                this.miejsce_zam.Text = lekarz.First().miescje_zam;
                this.ulica.Text = lekarz.First().adres;
                this.kod.Text = lekarz.First().kod_pocztowy;
                this.pesel.Text = lekarz.First().pesel;
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
                                       data_nad = ls.data_nadania,
                                       id = s.ID_Specjalnosci
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
                                       wgodzina = w.czas,
                                       wimie = p.imie,
                                       wnazwisko = p.nazwisko, 
                                       odbyta = w.czy_odbyta
                                   };
                dgvWizyty.DataSource = wizyty.ToList();
            }
        }

        public void wypenijDanymiPacjentow()
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                var pacjenci = from w in dc.Wizyty
                             where w.ID_Lekarza == this.index
                             join p in dc.Pacjenci on w.ID_Pacjenta equals p.ID_Pacjenta
                             orderby w.data descending, w.czas descending
                             select new
                             {
                                 p_imie = p.imie,
                                 p_nazwisko = p.nazwisko,
                                 p_data_ur = p.data_urodzenia,
                                 ppesel = p.PESEL,
                                 p_ulica = p.ulica,
                                 p_miejsce_ur = p.miejsce_urodzenia,
                                 p_adres = p.miejsce_zamieszkania,
                                 p_kod = p.kod_pocztowy
                             };
                dgvPacjenci.DataSource = pacjenci.ToList();
            }
        }


        private void button_Click(object sender, EventArgs e)
        {
            if (szczegoly) {
                using (var dc = new EntitiesPrzychodnia()){
                    var lekarz = dc.Lekarze.Single(p => p.ID_Lekarza == index);

                    lekarz.imie = imie.Text;
                    lekarz.nazwisko = nazwisko.Text;
                    lekarz.data_urodzenia = this.dtpUrodzenia.Value;
                    lekarz.miejsce_urodzenia = miejsce_ur.Text;
                    lekarz.miejsce_zamieszkania = miejsce_zam.Text;
                    lekarz.PESEL = pesel.Text;
                    lekarz.ulica = ulica.Text;
                    lekarz.kod_pocztowy = kod.Text;
                    button.Enabled = true;
                    try{
                        dc.SaveChanges();
                    }
                    catch{
                        MessageBox.Show("Nie udało się zaktualizować rekordu");
                    }
                }
            }
            else{
                using (var dc = new EntitiesPrzychodnia()){
                    var lekarz = new Lekarze();
                    lekarz.imie = imie.Text;
                    lekarz.nazwisko = nazwisko.Text;
    
                    try
                    {
                        lekarz.data_urodzenia = this.dtpUrodzenia.Value;                
                    }
                    catch
                    {
                        MessageBox.Show("Błędny format daty - spróbuj jescze raz!");
                    }
                    lekarz.miejsce_urodzenia = miejsce_ur.Text;
                    lekarz.miejsce_zamieszkania = miejsce_zam.Text;
                    lekarz.PESEL = pesel.Text;
                    lekarz.ulica = ulica.Text;
                    lekarz.kod_pocztowy = kod.Text;                    
                    lekarz.plec = (lekarz.imie.Substring(lekarz.imie.Length-1,1) == "a" ? "k" : "m") ;

                    try
                    {
                        dc.Lekarze.Add(lekarz);
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
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LekarzeSzczegoly_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            if (szczegoly)
            {
                wypenijDanymi();
                this.Text = String.Format("{0} {1} - Szczegóły", imie.Text, nazwisko.Text);
                button.Text = "Zapisz";
                wypenijDanymiSpecjalnosci();
                wypenijDanymiWizyty();
                wypenijDanymiPacjentow();
            }
            else
            {
                this.Text = "Dodaj Lekarza";
                button.Text = "Dodaj";
                this.Height = this.Height - panel1.Height;
                panel1.Visible = false;
            }
        }


        private void dgv_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridView dgv = (DataGridView)sender;
                dgv.Rows[e.RowIndex].Selected = true;
                dgv.Focus();
            }
            catch { }
        }

        private void usunSpecjalizacje(int id)
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                var specjalizacja = from ls in dc.LekarzSpecjalnosc
                                    where ls.ID_Specjalnosci == id && ls.ID_Lekarza == this.index
                                    select ls;

                dc.LekarzSpecjalnosc.RemoveRange(specjalizacja);
                try
                {
                    dc.SaveChanges();
                }
                catch { }
            }

        }

        private void cmsSpecjalnosci_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            int index = dgvSpecjalnosci.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (index > -1)
            {
                int id = (int)dgvSpecjalnosci.Rows[index].Cells["id"].Value;
                if (item.Name == "spec_usun")
                {
                    usunSpecjalizacje(id);
                }         
            }
            
            if (item.Name == "spec_dodaj")
            {
                DodajSpecjalnosc win = new DodajSpecjalnosc(this.index);
                win.Text = "Dodaj specjalnosc - " + imie.Text + " " + nazwisko.Text;
                win.lekarz = false;
                win.ShowDialog();
            }
            wypenijDanymiSpecjalnosci();
            
        }

        private void validacja(object sender, EventArgs e)
        {
            aktywujZapisz();
        }

        void aktywujZapisz() { 
            button.Enabled = (
                Validacja.Tekst(imie.Text,true) &&
                Validacja.Tekst(nazwisko.Text, true) &&
                Validacja.Tekst(miejsce_ur.Text, true) &&
                Validacja.Tekst(miejsce_zam.Text, true) &&
                Validacja.Tekst(ulica.Text,false) &&
                Validacja.Kod(kod.Text)&&
                !String.IsNullOrEmpty(pesel.Text));
        }
 
        



    }
}

    

