using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;



namespace Przychodnia_rejestracja
{
    public partial class MainWindow : Form
    {
        int index;
        public MainWindow()
        {
            InitializeComponent();
            wyswietlLekarzy();
            wyswietlSwiadczenia();
            wyswietlChoroby();
        }


        #region Lekarze
            // Wyswietl lekarzy w data grid view
            public void wyswietlLekarzy()
            {
                using (var dc = new EntitiesPrzychodnia())
                {
                    var lekarze = from c in dc.Lekarze
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
                    dgvLekarze.DataSource = lekarze.ToList();
                }
            }
            private void cmsLekarze_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
            {
                ToolStripItem item = e.ClickedItem;
                int index = dgvLekarze.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                if (index > -1)
                {
                    int id = (int)dgvLekarze.Rows[index].Cells["id"].Value;

                    if (item.Name == "lekarze_szczegoly")
                    {
                        LekarzeSzczegoly win = new LekarzeSzczegoly(id);
                        win.ShowDialog();
                    }
                    else if (item.Name == "lekarze_dodaj")
                    {
                        LekarzeSzczegoly win = new LekarzeSzczegoly(id);
                        win.szczegoly = false;
                        win.ShowDialog();
                    }
                    wyswietlLekarzy();
                }

            }

        #endregion

        #region Choroby
            public void wyswietlChoroby()
            {
                using (var dc = new EntitiesPrzychodnia())
                {
                    var choroby = from s in dc.Choroby
                                  select new
                                  {
                                      ch_id = s.ID_Choroby,
                                      ch_nazwa = s.nazwa,
                                      ch_opis = s.opis
                                  };
                    dgvChoroby.DataSource = choroby.ToList();
                }
            }
            private bool sprawdzCzyChorobaIstnieje(string nazwa)
            {
                using (var dc = new EntitiesPrzychodnia())
                {
                    var choroba = from s in dc.Choroby
                                  where
                                      s.nazwa == nazwa
                                  select s;
                    if (choroba.Count() > 0)
                        return true;
                }
                return false;
            }
            private void dodajChorobe(string nazwa, string opis)
            {
                using (var dc = new EntitiesPrzychodnia())
                {
                    var choroba = new Choroby();
                    choroba.nazwa = nazwa;
                    choroba.opis = opis;
                    try
                    {
                        dc.Choroby.Add(choroba);
                        dc.SaveChanges();
                    }
                    catch { }
                }
            }
            private void EdytujChorobe()
            {
                int id = dgvChoroby.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                if (id >= 0)
                {
                    tbChoroba.Text = dgvChoroby.Rows[id].Cells["ch_nazwa"].Value.ToString();
                    tbChOpis.Text = dgvChoroby.Rows[id].Cells["ch_opis"].Value.ToString();
                    // Zamien przyciski miejscami
                    if (!bChZapisz.Visible)
                    {
                        ZamienMiejscami(bChDodaj, bChZapisz);
                        gbChoroby.Text = "Edytuj chorobę";
                        this.index = Convert.ToInt32(dgvChoroby.Rows[id].Cells["ch_id"].Value.ToString());
                    }
                }
            }
            void WyczyscPolaChoroby()
            {
                gbChoroby.Text = "Dodaj chorobę";
                tbChOpis.Text = "";
                tbChoroba.Text = "";
                wyswietlChoroby();
            }
            private void bChDodaj_Click(object sender, EventArgs e)
            {
                // Sprawdz czy pola nie sa puste
                if (!String.IsNullOrEmpty(tbChoroba.Text))
                {

                    if (!sprawdzCzyChorobaIstnieje(tbChoroba.Text))
                    {
                        dodajChorobe(tbChoroba.Text, tbChOpis.Text);
                        wyswietlChoroby();
                    }
                    else
                    {
                        MessageBox.Show("Taka choroba już istnieje!");
                    }
                }
                else
                {
                    MessageBox.Show("Pole \"nazwa\" nie może być puste!");
                }
            }
            private void bChZapisz_Click(object sender, EventArgs e)
            {
                using (var dc = new EntitiesPrzychodnia())
                {
                    var choroba = dc.Choroby.Single(ch => ch.ID_Choroby == this.index);
                    choroba.opis = tbChOpis.Text;
                    choroba.nazwa = tbChOpis.Text;
                    try
                    {
                        dc.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Nie udało się zaktualizować rekordu");
                    }
                }
                ZamienMiejscami(bChDodaj, bChZapisz);
                WyczyscPolaChoroby();
            }
            private void bChAnuluj_Click(object sender, EventArgs e)
            {
                WyczyscPolaChoroby();
            }
        #endregion

        #region Swiadczenia

            public void wyswietlSwiadczenia()
            {
                using (var dc = new EntitiesPrzychodnia())
                {
                    var swiadczenia = from s in dc.Swiadczenia
                                      select new
                                      {
                                          s_id = s.ID_Swiadczenia,
                                          s_nazwa = s.nazwa,
                                          s_koszt = s.koszt
                                      };
                    dgvSwiadczenia.DataSource = swiadczenia.ToList();
                }
            }
            private bool sprawdzCzySwiadczeniaIstnieje(string nazwa, double koszt)
            {
                using (var dc = new EntitiesPrzychodnia())
                {
                    var swiadczenia = from s in dc.Swiadczenia
                                      where
                                          s.koszt == koszt &&
                                          s.nazwa == nazwa
                                      select s;
                    if (swiadczenia.Count() > 0)
                        return true;
                }
                return false;
            }
            private void dodajSwiadczenie(string nazwa, double koszt)
            {
                using (var dc = new EntitiesPrzychodnia())
                {
                    var swiadczenie = new Swiadczenia();
                    swiadczenie.nazwa = nazwa;
                    swiadczenie.koszt = koszt;
                    try
                    {
                        dc.Swiadczenia.Add(swiadczenie);
                        dc.SaveChanges();
                    }
                    catch { }
                }
            }
            private void EdytujSwiadczenie()
            {
                int id = dgvSwiadczenia.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                if (id >= 0)
                {
                    tbSwiadczenia.Text = dgvSwiadczenia.Rows[id].Cells["s_nazwa"].Value.ToString();
                    tbKoszt.Text = dgvSwiadczenia.Rows[id].Cells["s_koszt"].Value.ToString();
                    // Zamien przyciski miejscami
                    if (!bEdytujSwiadczenie.Visible)
                    {
                        ZamienMiejscami(bDodajSwiadczenie, bEdytujSwiadczenie);
                        gbSwiadczenia.Text = "Edytuj świadczenie";
                        this.index = Convert.ToInt32(dgvSwiadczenia.Rows[id].Cells["s_id"].Value.ToString());
                    }
                }
            }
            private void dodaj_swiadczenia_Click(object sender, EventArgs e)
            {
                // Sprawdz czy pola nie sa puste
                if (!String.IsNullOrEmpty(tbSwiadczenia.Text) &&
                    !String.IsNullOrEmpty(tbSwiadczenia.Text))
                {
                    double koszt = Convert.ToDouble(tbKoszt.Text);
                    if (!sprawdzCzySwiadczeniaIstnieje(tbSwiadczenia.Text, koszt))
                    {
                        dodajSwiadczenie(tbSwiadczenia.Text, koszt);
                        wyswietlSwiadczenia();
                        WyczyscPolaSwiadczenia();
                    }
                    else
                    {
                        MessageBox.Show("Takie świadczenie już istnieje!");
                    }
                }
                else
                {
                    MessageBox.Show("Pola \"nazwa\" i \"koszt\" nie mogą być puste!");
                }
            }
            private void bEdytujSwiadczenie_Click(object sender, EventArgs e)
            {
                using (var dc = new EntitiesPrzychodnia())
                {
                    var swiadczenie = dc.Swiadczenia.Single(s => s.ID_Swiadczenia == this.index);
                    swiadczenie.koszt = Convert.ToDouble(tbKoszt.Text);
                    swiadczenie.nazwa = tbSwiadczenia.Text;
                    try
                    {
                        dc.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Nie udało się zaktualizować rekordu");
                    }
                }
                ZamienMiejscami(bDodajSwiadczenie, bEdytujSwiadczenie);
                WyczyscPolaSwiadczenia();
            }
            void WyczyscPolaSwiadczenia()
            {
                gbSwiadczenia.Text = "Dodaj świadczenie";
                tbKoszt.Text = "";
                tbSwiadczenia.Text = "";
                wyswietlSwiadczenia();
            }
            
            private void bAnulujSwiadczenie_Click(object sender, EventArgs e)
            {
                WyczyscPolaSwiadczenia();
            }

        #endregion

        #region Wspolne
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
            // Sprawdzanie poprawności formatu: pieniądze
            private bool PoprawnyFormat_Pieniadze(string text)
            {
                Match match = Regex.Match(text, @"^[0-9]{0,6}(\.[0-9]{1,2})?$");
                return match.Success;
            }

            // Sprawdzanie poprawności formatu: pieniądze
            private bool PoprawnyFormat_Tekst(string text, bool firstCapitalRequired = false)
            {
                Match match;
                if (firstCapitalRequired)
                    match = Regex.Match(text, "^[A-ZŚŻŹŁ][a-zA-Z -ąęćśżźółńćŚŻŹŁ]*$");
                else
                    match = Regex.Match(text, "^[a-zA-Z -ąęćżźśółńćŚŻŹŁ]+$");
                return match.Success;
            }

            // Sprawdzanie poprawności formatu: pieniądze - Zdarzenie
            private void SprawdzFormat_Pieniadze(object sender, EventArgs e)
            {
                TextBox tb = (TextBox)sender;
                switch (tb.Name)
                {
                    case "tbKoszt":
                        this.bDodajSwiadczenie.Enabled = PoprawnyFormat_Pieniadze(tb.Text);
                        break;
                }
            }

            // Sprawdzanie poprawności formatu: tekst - Zdarzenie
            private void SprawdzFormat_Tekst(object sender, EventArgs e)
            {
                TextBox tb = (TextBox)sender;
                switch (tb.Name)
                {
                    case "tbSwiadczenia":
                        this.bDodajSwiadczenie.Enabled = PoprawnyFormat_Tekst(tb.Text, true);
                        break;
                    case "tbChoroba":
                        this.bChDodaj.Enabled = PoprawnyFormat_Tekst(tb.Text, true);
                        break;
                }
            }
            private void dgvRow_DoubleClicked(object sender, DataGridViewCellEventArgs e)
            {
                try
                {
                    DataGridView dgv = (DataGridView)sender;
                    dgv.Rows[e.RowIndex].Selected = true;
                    dgv.Focus();

                    switch (dgv.Name)
                    {
                        case "dgvSwiadczenia":
                            EdytujSwiadczenie();
                            break;
                        case "dgvChoroby":
                            EdytujChorobe();
                            break;
                    }

                }
                catch { }
            }

            private void VisibleChanged(object sender, EventArgs e)
            {     
                Button button = (Button)sender;
                switch (button.Name){
                    case "bEdytujSwiadczenie":
                        bAnulujSwiadczenie.Visible = button.Visible;
                        break;

                    case "bChZapisz":
                        bChAnuluj.Visible = button.Visible;
                        break;
                
                }
                
            }
        #endregion



    }
}
