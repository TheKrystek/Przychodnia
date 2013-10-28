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
using System.Xml.Linq;



namespace Przychodnia_rejestracja
{
    public partial class MainWindow : Form
    {
        int lekarstwo_id;
        int choroba_id;
        int swiadczenie_id;
        int specjalnosc_id;
        int wizyta_id;

        public MainWindow()
        {
            InitializeComponent();

            wczytajDaneDoFiltrowLekarzy();
            wczytajDaneDoFiltrowPacjentow();
            wczytajDaneDoFiltrowWizyt();

            wyswietlWizyty();
            wyswietlLekarzy();
            wyswietlSwiadczenia();
            wyswietlChoroby();
            wyswietlSpecjalnosci();
            wyswietlLekarstwa();
            wyswietlPacjentow();
        }

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

        // Sprawdzanie poprawności formatu - Zdarzenie
        private void SprawdzFormat_Tekst(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            switch (tb.Name)
            {
                case "tbKoszt":
                    this.bDodajSwiadczenie.Enabled = Validacja.Pieniadze(tb.Text);
                    break;
                case "tbLekCena":
                    bLekDodaj.Enabled = Validacja.Pieniadze(tb.Text);
                    break;
                case "tbSwiadczenia":
                    bDodajSwiadczenie.Enabled = Validacja.Tekst(tb.Text, true);
                    break;
                case "tbChoroba":
                    bChDodaj.Enabled = Validacja.Tekst(tb.Text, true);
                    break;
                case "tbSpecjalnosc":
                    bSpDodaj.Enabled = Validacja.Tekst(tb.Text, true);
                    break;
                case "tbLekarstwo":
                    bLekDodaj.Enabled = Validacja.Tekst(tb.Text, true);
                    break;
            }
        }
      
        // Dwuklik na polu oznacza przejscie do trybu edycji
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
                    case "dgvSpecjalnosci":
                        EdytujSpecjalnosc();
                        break;
                    case "dgvLekarstwa":
                        EdytujLekarstwo();
                        break;
                }
                dgv.Enabled = false;

            }
            catch { Console.WriteLine("Wyjatek w dgvRow_DoubleClicked"); }
        }
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridView dgv = (DataGridView)sender;
                int index = dgv.CurrentCell.RowIndex;
                if (index > -1){
                    DateTime data = Convert.ToDateTime(dgv.Rows[index].Cells["w_data"].Value.ToString());
                    bool zaznaczony = Convert.ToBoolean(dgv.Rows[index].Cells["w_odbyta"].Value);
                    
                    bWizytyPrzeloz.Enabled = (data >= DateTime.Now && !zaznaczony);
                    wizyta_id = Convert.ToInt32(dgv.Rows[index].Cells["w_id"].Value.ToString());
                }

            }
            catch { Console.WriteLine("Wyjatek w dgv_SelectionChanged"); }
        }

        private void VisibleChanged(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "bEdytujSwiadczenie":
                    bAnulujSwiadczenie.Visible = button.Visible;
                    break;

                case "bChZapisz":
                    bChAnuluj.Visible = button.Visible;
                    break;

                case "bSpZapisz":
                    bSpAnuluj.Visible = button.Visible;
                    break;

                case "bLekZapisz":
                    bLekAnuluj.Visible = button.Visible;
                    break;
            }

        }
        #endregion

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
                ustawStatus(dgvLekarze);
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
            private void ustawWartoscDomyslnaFiltrowLekarzy() {
                cbLekarzeImie.SelectedIndex = 0;
                cbLekarzeNazwisko.SelectedIndex = 0;
                cbLekarzeWiek.SelectedIndex = 0;
                cbLekarzeMiasto.SelectedIndex = 0;
                cbLekarzeSpecjalnosc.SelectedIndex = 0;
            }
            private void wczytajDaneDoFiltrowLekarzy() {
                ustawWartoscDomyslnaFiltrowLekarzy();
                wczytajDaneLekarzy();
                wczytajSpecjalnosciLekarzy();
            }
            private void wczytajSpecjalnosciLekarzy() {
                using (var dc = new EntitiesPrzychodnia())
                {
                    var specjalnosci = from s in dc.Specjalnosci orderby s.nazwa ascending
                                       select new
                                       {
                                           nazwa = s.nazwa
                                       };
                    foreach (var specjalnosc in specjalnosci)
                        cbLekarzeSpecjalnosc.Items.Add(specjalnosc.nazwa);
                }     

            }
            private void wczytajDaneLekarzy() {
                using (var dc = new EntitiesPrzychodnia())
                {
                    var lekarze = from c in dc.Lekarze
                                  select new
                                  {
                                      imie = c.imie,
                                      nazwisko = c.nazwisko,
                                      miasto = c.miejsce_zamieszkania
                                  };

                    List<String> imiona = new List<String>();
                    List<String> nazwiska = new List<String>();
                    List<String> miasta = new List<String>();
                    foreach (var lekarz in lekarze){              
                        if (!imiona.Contains(lekarz.imie))
                            imiona.Add(lekarz.imie);

                        if (!nazwiska.Contains(lekarz.nazwisko))
                            nazwiska.Add(lekarz.nazwisko);

                        if (!miasta.Contains(lekarz.miasto))
                            miasta.Add(lekarz.miasto);
                    }

                    imiona.Sort();
                    nazwiska.Sort();
                    miasta.Sort();

                    cbLekarzeImie.Items.AddRange(imiona.ToArray());
                    cbLekarzeNazwisko.Items.AddRange(nazwiska.ToArray());
                    cbLekarzeMiasto.Items.AddRange(miasta.ToArray());

                    int krok = 10; // co 10 lat
                    for (int i = 21; i < 100; i += krok) { 
                        string item = String.Format("{0} - {1}",i.ToString(), (i+krok-1).ToString());
                        cbLekarzeWiek.Items.Add(item);                  
                    }
                    cbLekarzeWiek.Items.Add("Powyżej");                  
                    

                }     
            }
            private void konstuujFiltrLekarzy() {
                using (var dc = new EntitiesPrzychodnia())
                {
                    if ((string)cbLekarzeSpecjalnosc.SelectedItem == "Dowolna"){
                        konstruujFiltryLekarzyBezSpecjalnosci(dc);
                    }

                    if ((string)cbLekarzeSpecjalnosc.SelectedItem != "Dowolna" || cbLekarzeSpecjalnosci.Checked){
                        konstruujFiltryLekarzyZeSpecjalnoscia(dc);  
                    }
                }       
            }
            private void konstruujFiltryLekarzyBezSpecjalnosci(EntitiesPrzychodnia dc)
            {
                var query = from l in dc.Lekarze
                            select new
                            {
                                imie = l.imie,
                                nazwisko = l.nazwisko,
                                miejsce_ur = l.miejsce_urodzenia,
                                data_ur = l.data_urodzenia,
                                id = l.ID_Lekarza,
                                miescje_zam = l.miejsce_zamieszkania,
                                adres = l.ulica,
                                kod_pocztowy = l.kod_pocztowy
                            };
                if ((string)cbLekarzeImie.SelectedItem != "Dowolne")
                    query = query.Where(l => (string)l.imie == (string)cbLekarzeImie.SelectedItem);

                if ((string)cbLekarzeNazwisko.SelectedItem != "Dowolne")
                    query = query.Where(l => (string)l.nazwisko == (string)cbLekarzeNazwisko.SelectedItem);

                if ((string)cbLekarzeMiasto.SelectedItem != "Dowolne")
                    query = query.Where(l => (string)l.miescje_zam == (string)cbLekarzeMiasto.SelectedItem);
                if ((string)cbLekarzeWiek.SelectedItem != "Dowolny")
                {
                    string value = (string)cbLekarzeWiek.SelectedItem;
                    if (value == "Powyżej")
                    {
                        query = query.Where(l => DateTime.Now.Year - l.data_ur.Value.Year >= 101);
                    }
                    else
                    {
                        try
                        {
                            var split = value.Split('-');
                            int dol = Convert.ToInt32(split[0]);
                            int gora = Convert.ToInt32(split[1]);
                            query = query.Where(l => DateTime.Now.Year - l.data_ur.Value.Year >= dol);
                            query = query.Where(l => DateTime.Now.Year - l.data_ur.Value.Year <= gora);
                        }
                        catch
                        {
                            MessageBox.Show("Nie udało się rozbić wieku na dwie liczby");
                        }
                    }
                }
                var lista = query.ToList();
                lista.Distinct();
                dgvLekarze.DataSource = lista;
            }
            private void konstruujFiltryLekarzyZeSpecjalnoscia(EntitiesPrzychodnia dc)
            {
                var query = from l in dc.Lekarze
                            join ls in dc.LekarzSpecjalnosc on l.ID_Lekarza equals ls.ID_Lekarza into a
                            from ls in a.DefaultIfEmpty()
                            join s in dc.Specjalnosci on ls.ID_Specjalnosci equals s.ID_Specjalnosci into b
                            from s in b.DefaultIfEmpty()
                            select new
                            {
                                specjalnosc = s.nazwa,
                                imie = l.imie,
                                nazwisko = l.nazwisko,
                                miejsce_ur = l.miejsce_urodzenia,
                                data_ur = l.data_urodzenia,
                                id = l.ID_Lekarza,
                                miescje_zam = l.miejsce_zamieszkania,
                                adres = l.ulica,
                                kod_pocztowy = l.kod_pocztowy
                            };
                if ((string)cbLekarzeImie.SelectedItem != "Dowolne")
                    query = query.Where(l => (string)l.imie == (string)cbLekarzeImie.SelectedItem);

                if ((string)cbLekarzeNazwisko.SelectedItem != "Dowolne")
                    query = query.Where(l => (string)l.nazwisko == (string)cbLekarzeNazwisko.SelectedItem);

                if ((string)cbLekarzeMiasto.SelectedItem != "Dowolne")
                    query = query.Where(l => (string)l.miescje_zam == (string)cbLekarzeMiasto.SelectedItem);

                if ((string)cbLekarzeSpecjalnosc.SelectedItem != "Dowolna")
                {
                    query = query.Where(s => (string)s.specjalnosc == (string)cbLekarzeSpecjalnosc.SelectedItem);
                }
                if ((string)cbLekarzeWiek.SelectedItem != "Dowolny")
                {
                    string value = (string)cbLekarzeWiek.SelectedItem;
                    if (value == "Powyżej")
                    {
                        query = query.Where(l => DateTime.Now.Year - l.data_ur.Value.Year >= 101);
                    }
                    else
                    {
                        try
                        {
                            var split = value.Split('-');
                            int dol = Convert.ToInt32(split[0]);
                            int gora = Convert.ToInt32(split[1]);
                            query = query.Where(l => DateTime.Now.Year - l.data_ur.Value.Year >= dol);
                            query = query.Where(l => DateTime.Now.Year - l.data_ur.Value.Year <= gora);
                        }
                        catch
                        {
                            MessageBox.Show("Nie udało się rozbić wieku na dwie liczby");
                        }
                    }
                }
                var lista = query.ToList();
                lista.Distinct();
                dgvLekarze.DataSource = lista;
            }
            private void bLekarzeSzukaj_Click(object sender, EventArgs e)
            {
                konstuujFiltrLekarzy();
            }
            private void bLekarzeWyczysc_Click(object sender, EventArgs e)
            {
                ustawWartoscDomyslnaFiltrowLekarzy();
                konstuujFiltrLekarzy();
            }
            private void cbLekarzeSpecjalnosci_CheckedChanged(object sender, EventArgs e)
            {
                CheckBox item = (CheckBox)sender;
                try
                {
                    dgvLekarze.Columns["specjalnosc"].Visible = item.Checked;
                }
                catch { }
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
                    if (bChDodaj.Visible)
                    {
                        ZamienMiejscami(bChDodaj, bChZapisz);
                        gbChoroby.Text = "Edytuj chorobę";
                        this.choroba_id = Convert.ToInt32(dgvChoroby.Rows[id].Cells["ch_id"].Value.ToString());
                    }
                    tbChoroba.Text = dgvChoroby.Rows[id].Cells["ch_nazwa"].Value.ToString();
                    tbChOpis.Text = dgvChoroby.Rows[id].Cells["ch_opis"].Value.ToString();
                    // Zamien przyciski miejscami
            
                }
            }
            void WyczyscPolaChoroby()
            {
                gbChoroby.Text = "Dodaj chorobę";
                tbChOpis.Text = "";
                tbChoroba.Text = "";
                wyswietlChoroby();
                dgvChoroby.Enabled = true;
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
                    var choroba = dc.Choroby.Single(ch => ch.ID_Choroby == this.choroba_id);
                    choroba.opis = tbChOpis.Text;
                    choroba.nazwa = tbChoroba.Text;
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
                ZamienMiejscami(bChDodaj, bChZapisz);
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
                        this.swiadczenie_id = Convert.ToInt32(dgvSwiadczenia.Rows[id].Cells["s_id"].Value.ToString());
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
                    var swiadczenie = dc.Swiadczenia.Single(s => s.ID_Swiadczenia == this.swiadczenie_id);
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
                dgvSwiadczenia.Enabled = true;
                wyswietlSwiadczenia();
            }           
            private void bAnulujSwiadczenie_Click(object sender, EventArgs e)
            {
                WyczyscPolaSwiadczenia();
                ZamienMiejscami(bDodajSwiadczenie, bEdytujSwiadczenie);
            }

        #endregion

        #region Specjalnosci
            public void wyswietlSpecjalnosci()
            {
                using (var dc = new EntitiesPrzychodnia())
                {
                    var specjalnosci = from s in dc.Specjalnosci
                                    select new
                                    {
                                        sp_id = s.ID_Specjalnosci,
                                        sp_nazwa = s.nazwa,       
                                    };
                    dgvSpecjalnosci.DataSource = specjalnosci.ToList();
                }
            }
            private bool sprawdzCzySpecjalnoscIstnieje(string nazwa)
            {
                using (var dc = new EntitiesPrzychodnia())
                {
                    var specjalnosc = from s in dc.Specjalnosci
                                    where
                                        s.nazwa == nazwa
                                    select s;
                    if (specjalnosc.Count() > 0)
                        return true;
                }
                return false;
            }
            private void dodajSpecjalnosc(string nazwa)
            {
                using (var dc = new EntitiesPrzychodnia())
                {
                    var specjalnosc = new Specjalnosci();
                    specjalnosc.nazwa = nazwa;
                    try
                    {
                        dc.Specjalnosci.Add(specjalnosc);
                        dc.SaveChanges();
                    }
                    catch { }
                }
            }
            private void EdytujSpecjalnosc()
            {
                int id = dgvSpecjalnosci.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                if (id >= 0)
                {
                    tbSpecjalnosc.Text = dgvSpecjalnosci.Rows[id].Cells["sp_nazwa"].Value.ToString();
                    //tbSpOpis.Text = dgvSpecjalnosci.Rows[id].Cells["ch_opis"].Value.ToString();
                    // Zamien przyciski miejscami
                    if (!bSpZapisz.Visible)
                    {
                        ZamienMiejscami(bSpDodaj, bSpZapisz);
                        gbSpecjalnosci.Text = "Edytuj specjalność";
                        this.specjalnosc_id = Convert.ToInt32(dgvSpecjalnosci.Rows[id].Cells["sp_id"].Value.ToString());
                    }
                }
            }
            void WyczyscPolaSpecjalnosci()
            {
                gbSpecjalnosci.Text = "Dodaj specjalność";
                tbSpecjalnosc.Text = "";
                wyswietlSpecjalnosci();
                dgvSpecjalnosci.Enabled = true;
            }
            private void bSpDodaj_Click(object sender, EventArgs e)
            {
                // Sprawdz czy pola nie sa puste
                if (!String.IsNullOrEmpty(tbSpecjalnosc.Text))
                {

                    if (!sprawdzCzySpecjalnoscIstnieje(tbSpecjalnosc.Text))
                    {
                        dodajSpecjalnosc(tbSpecjalnosc.Text);
                        wyswietlSpecjalnosci();
                    }
                    else
                    {
                        MessageBox.Show("Taka specjalnosc już istnieje!");
                    }
                }
                else
                {
                    MessageBox.Show("Pole \"nazwa\" nie może być puste!");
                }
            }
            private void bSpZapisz_Click(object sender, EventArgs e)
            {
                using (var dc = new EntitiesPrzychodnia())
                {
                    var specjalnosc = dc.Specjalnosci.Single(ch => ch.ID_Specjalnosci == this.specjalnosc_id);
               
                    specjalnosc.nazwa = tbSpecjalnosc.Text;
                    try
                    {
                        dc.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Nie udało się zaktualizować rekordu");
                    }
                }
                ZamienMiejscami(bSpDodaj, bSpZapisz);
                WyczyscPolaSpecjalnosci();
            }
            private void bSpAnuluj_Click(object sender, EventArgs e)
            {
                WyczyscPolaSpecjalnosci();
                ZamienMiejscami(bSpDodaj, bSpZapisz);
            }
        #endregion

        #region Lekarstwa
        public void wyswietlLekarstwa()
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                var lekarstwo = from s in dc.Lekarstwa
                                    select new
                                    {
                                        lek_id = s.ID_Lekarstwa,
                                        lek_nazwa = s.nazwa,
                                        lek_cena = s.cena,
                                        lek_ulotka = s.ulotka
                                    };
                dgvLekarstwa.DataSource = lekarstwo.ToList();
            }
        }
        private bool sprawdzCzyLekarstwoIstnieje(string nazwa)
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                var lekarstwo = from s in dc.Lekarstwa
                                    where
                                        s.nazwa == nazwa
                                    select s;
                if (lekarstwo.Count() > 0)
                    return true;
            }
            return false;
        }
        private void dodajLekarstwo(string nazwa,double cena, string xml)
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                var lekarstwo = new Lekarstwa();
                lekarstwo.nazwa = nazwa;
                lekarstwo.cena = cena;
                lekarstwo.ulotka = xml;
                try
                {
                    dc.Lekarstwa.Add(lekarstwo);
                    dc.SaveChanges();
                }
                catch { }
            }
        }
        private void EdytujLekarstwo()
        {
            int id = dgvLekarstwa.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (id >= 0)
            {
                WyczyscPolaLekarstwa(true);
                this.lekarstwo_id = Convert.ToInt32(dgvLekarstwa.Rows[id].Cells["lek_id"].Value.ToString());
                tbLekarstwo.Text = dgvLekarstwa.Rows[id].Cells["lek_nazwa"].Value.ToString();
                tbLekCena.Text = dgvLekarstwa.Rows[id].Cells["lek_cena"].Value.ToString();
                string ulotka = dgvLekarstwa.Rows[id].Cells["lek_ulotka"].Value.ToString();
                // obsluga xmla 
                if (!String.IsNullOrEmpty(ulotka))
                {                  
                    XElement ulotka_xml = XElement.Parse(ulotka);
                    try
                    {
                        if (ulotka_xml.Element("dawkowanie").Value != null)
                            tbLekDawkowanie.Text = ulotka_xml.Element("dawkowanie").Value;

                        if (ulotka_xml.Element("podmiot").Value != null)
                            tbLekPodmiot.Text = ulotka_xml.Element("podmiot").Value;


                        if (ulotka_xml.Element("przeciwwskazania").Value != null)
                            foreach (var element in ulotka_xml.Element("przeciwwskazania").Elements())
                                tbLekPrzeciwwskazania.Text += (element.Value.ToString() + ", ");
                        
                        if (ulotka_xml.Element("sklad").Value != null)
                            foreach (var element in ulotka_xml.Element("sklad").Elements())
                                tbLekSklad.Text += (element.Value.ToString() + ", ");

                        if (ulotka_xml.Element("zalecenia").Value != null)
                            foreach (var element in ulotka_xml.Element("zalecenia").Elements())
                                tbLekZalecenia.Text += (element.Value.ToString() + ", ");

                        if (ulotka_xml.Element("niepozadane").Value != null)
                            foreach (var element in ulotka_xml.Element("niepozadane").Elements())
                                tbLekNiepozadane.Text += (element.Value.ToString() + ", ");

                        if (ulotka_xml.Element("opakowania").Value != null)
                            foreach (var element in ulotka_xml.Element("opakowania").Elements())
                                tbLekOpakowania.Text += (element.Value.ToString() + ", ");
                         
                    }
                    catch (Exception e) {
                        MessageBox.Show("Ulotka zawiera niepoprawny XML (np. brakuje któregoś z pól)");
                    }
                }
                else {
                    Console.WriteLine("Pusty string");
                }

                if (!bLekZapisz.Visible)
                {
                    ZamienMiejscami(bLekDodaj, bLekZapisz);
                    gbLekarstwa.Text = "Edytuj lekarstwo";
                    
                }
            }
        }
        void WyczyscPolaLekarstwa(bool tylkoWyczysc = false)
        {        
            tbLekCena.Text = "";
            tbLekDawkowanie.Text = "";
            tbLekNiepozadane.Text = "";
            tbLekOpakowania.Text = "";
            tbLekPodmiot.Text = "";
            tbLekPrzeciwwskazania.Text = "";
            tbLekSklad.Text = "";
            tbLekZalecenia.Text = "";
            tbLekarstwo.Text = "";
            dgvLekarstwa.Enabled = true;
            if (!tylkoWyczysc)
            {
                gbLekarstwa.Text = "Dodaj lekarstwo";
                wyswietlLekarstwa();
            }
        }
        private void bLekDodaj_Click(object sender, EventArgs e)
        {
            // Sprawdz czy pola nie sa puste
            if (!String.IsNullOrEmpty(tbLekarstwo.Text) &&
                !String.IsNullOrEmpty(tbLekCena.Text))
            {
                if (!sprawdzCzyLekarstwoIstnieje(tbLekarstwo.Text))
                {
                    // Formatowanie ulotki
                    string ulotka = formatujUlotke().ToString();
                    dodajLekarstwo(tbLekarstwo.Text,Convert.ToDouble(tbLekCena.Text),ulotka);
                    wyswietlLekarstwa();
                }
                else
                {
                    MessageBox.Show("Taka lekarstwo już istnieje!");
                }
            }
            else
            {
                MessageBox.Show("Pole \"nazwa\" nie może być puste!");
            }
        }
        private void bLekZapisz_Click(object sender, EventArgs e)
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                var lekarstwo = dc.Lekarstwa.Single(ch => ch.ID_Lekarstwa == this.lekarstwo_id);

                lekarstwo.nazwa = tbLekarstwo.Text;
                lekarstwo.cena = Convert.ToDouble(tbLekCena.Text);
                lekarstwo.ulotka = formatujUlotke().ToString();

                try
                {
                    dc.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Nie udało się zaktualizować rekordu");
                }
            }
            ZamienMiejscami(bSpDodaj, bSpZapisz);
            WyczyscPolaLekarstwa();
        }
        private void bLekAnuluj_Click(object sender, EventArgs e)
        {
            WyczyscPolaLekarstwa();
            ZamienMiejscami(bLekDodaj, bLekZapisz);
        }
        private XElement formatujFragmentUlotki(string parent, string child, string dataSource) {
            
            if (!String.IsNullOrEmpty(dataSource))
            {
                XElement element = new XElement(parent);
                string tmp = dataSource.Replace(", ", ";");
                tmp = (tmp[tmp.Length - 1] == ';' ? tmp.Remove(tmp.Length - 1) : tmp);
                foreach (string s in tmp.Split(';'))
                    element.Add(new XElement(child, s.Trim()));
                return element;
            }
            return new XElement(parent,"");
        }
        private void dodajDoUlotki(string parent, string child, string dataSource,ref XElement dest)
        { 
          XElement element = formatujFragmentUlotki(parent, child, dataSource);
          if (element != null)
              dest.Add(element);
        }
        private XElement formatujUlotke() {
            XElement ulotka = new XElement("ulotka");
            ulotka.Add(new XElement("nazwa", tbLekarstwo.Text));
            ulotka.Add(new XElement("podmiot", tbLekPodmiot.Text));
            ulotka.Add(new XElement("dawkowanie",tbLekDawkowanie.Text));

            dodajDoUlotki("przeciwwskazania", "przeciwwskazanie", tbLekPrzeciwwskazania.Text, ref ulotka);
            dodajDoUlotki("sklad", "substancja", tbLekSklad.Text,ref ulotka);
            dodajDoUlotki("opakowania", "opakowanie", tbLekOpakowania.Text, ref ulotka);
            dodajDoUlotki("zalecenia", "zalecenie", tbLekZalecenia.Text, ref ulotka);
            dodajDoUlotki("niepozadane", "dzialanie", tbLekNiepozadane.Text, ref ulotka);
            return ulotka;
        }
        private void cmsLekarstwa_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            int index = dgvLekarstwa.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (index > -1)
            {
                int id = (int)dgvLekarstwa.Rows[index].Cells["lek_id"].Value;
                if (item.Name == "lekarstwa_ulotka")
                {
                    Ulotka ulotka = new Ulotka(id);
                    ulotka.Show();
                }
            }
        }
        #endregion

        #region Pacjenci
        public void wyswietlPacjentow()
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                var pacjenci = from c in dc.Pacjenci
                              select new
                              {
                                  p_imie = c.imie,
                                  p_nazwisko = c.nazwisko,
                                  p_miejsce_urodzenia = c.miejsce_urodzenia,
                                  p_data = c.data_urodzenia,
                                  p_id = c.ID_Pacjenta,
                                  p_miasto = c.miejsce_zamieszkania,
                                  p_adres = c.ulica,
                                  p_kod = c.kod_pocztowy
                              };
                dgvPacjenci.DataSource = pacjenci.ToList();
            }
        }
        private void ustawWartoscDomyslnaFiltrowPacjentow()
        {
            cbPacjenciImie.SelectedIndex = 0;
            cbPacjenciNazwisko.SelectedIndex = 0;
            cbPacjenciWiek.SelectedIndex = 0;
            cbPacjenciMiasto.SelectedIndex = 0;
            cbPacjenciLekarz.SelectedIndex = 0;
        }
        private void wczytajDaneDoFiltrowPacjentow()
        {
            ustawWartoscDomyslnaFiltrowPacjentow();
            wczytajDanePacjentow();
            wczytajLekarzyPacjentow();
        }
        private void wczytajLekarzyPacjentow()
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                var lekarze = from s in dc.Lekarze
                                   orderby s.nazwisko ascending
                                   select new
                                   {    
                                       imie = s.imie,
                                       nazwisko = s.nazwisko
                                   };
                foreach (var lekarz in lekarze)
                    cbPacjenciLekarz.Items.Add(String.Format("{0} {1}",lekarz.nazwisko,lekarz.imie));
            }

        }
        private void wczytajDanePacjentow()
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                var pacjenci = from c in dc.Pacjenci
                              select new
                              {
                                  imie = c.imie,
                                  nazwisko = c.nazwisko,
                                  miasto = c.miejsce_zamieszkania
                              };

                List<String> imiona = new List<String>();
                List<String> nazwiska = new List<String>();
                List<String> miasta = new List<String>();
                foreach (var pacjent in pacjenci)
                {
                    if (!imiona.Contains(pacjent.imie))
                        imiona.Add(pacjent.imie);

                    if (!nazwiska.Contains(pacjent.nazwisko))
                        nazwiska.Add(pacjent.nazwisko);

                    if (!miasta.Contains(pacjent.miasto))
                        miasta.Add(pacjent.miasto);
                }

                imiona.Sort();
                nazwiska.Sort();
                miasta.Sort();

                cbPacjenciImie.Items.AddRange(imiona.ToArray());
                cbPacjenciNazwisko.Items.AddRange(nazwiska.ToArray());
                cbPacjenciMiasto.Items.AddRange(miasta.ToArray());

                int krok = 10; // co 10 lat
                for (int i = 21; i < 100; i += krok)
                {
                    string item = String.Format("{0} - {1}", i.ToString(), (i + krok - 1).ToString());
                    cbPacjenciWiek.Items.Add(item);
                }
                cbPacjenciWiek.Items.Add("Powyżej");
            }
        }
        private void konstuujFiltrPacjentow()
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                 if ((string)cbPacjenciLekarz.SelectedItem != "Dowolny")
                    KonstruujFiltryPacjentowZLekarzem(dc);
                else
                    KonstruujFiltryPacjentowBezLekarzy(dc);
            }
            ustawStatus(dgvPacjenci);
        }
        private void KonstruujFiltryPacjentowBezLekarzy(EntitiesPrzychodnia dc)
{

                var query = from p in dc.Pacjenci
                            select new
                            {
                                p_imie = p.imie,
                                p_nazwisko = p.nazwisko,
                                p_miejsce_urodzenia = p.miejsce_urodzenia,
                                p_data = p.data_urodzenia,
                                p_id = p.ID_Pacjenta,
                                p_miasto = p.miejsce_zamieszkania,
                                p_adres = p.ulica,
                                p_kod = p.kod_pocztowy
                            };

                if ((string)cbPacjenciImie.SelectedItem != "Dowolne")
                    query = query.Where(p => (string)p.p_imie == (string)cbPacjenciImie.SelectedItem);

                if ((string)cbPacjenciNazwisko.SelectedItem != "Dowolne")
                    query = query.Where(p => (string)p.p_nazwisko == (string)cbPacjenciNazwisko.SelectedItem);

                if ((string)cbPacjenciMiasto.SelectedItem != "Dowolne")
                    query = query.Where(p => (string)p.p_miasto == (string)cbPacjenciMiasto.SelectedItem);
                    
                if ((string)cbPacjenciWiek.SelectedItem != "Dowolny")
                {
                    string value = (string)cbPacjenciWiek.SelectedItem;
                    if (value == "Powyżej")
                    {
                        query = query.Where(p => DateTime.Now.Year - p.p_data.Value.Year >= 101);
                    }
                    else
                    {
                        try
                        {
                            var split = value.Split('-');
                            int dol = Convert.ToInt32(split[0]);
                            int gora = Convert.ToInt32(split[1]);
                            query = query.Where(p => DateTime.Now.Year - p.p_data.Value.Year >= dol);
                            query = query.Where(p => DateTime.Now.Year - p.p_data.Value.Year <= gora);
                        }
                        catch
                        {
                            MessageBox.Show("Nie udało się rozbić wieku na dwie liczby");
                        }
                    }
                }
                try
                {
                    dgvPacjenci.Columns["p_lekarz"].Visible = false;
                    dgvPacjenci.DataSource = query.ToList();
                }
                catch
                {}     
        }
        private void KonstruujFiltryPacjentowZLekarzem(EntitiesPrzychodnia dc)
        {
            var query = from p in dc.Pacjenci
                        join w in dc.Wizyty on p.ID_Pacjenta equals w.ID_Pacjenta into a
                        from w in a.DefaultIfEmpty()
                        join l in dc.Lekarze on w.ID_Lekarza equals l.ID_Lekarza into b
                        from l in b.DefaultIfEmpty()
                        select new
                        {
                            p_lekarz = l.nazwisko + " " + l.imie,
                            p_imie = p.imie,
                            p_nazwisko = p.nazwisko,
                            p_miejsce_urodzenia = p.miejsce_urodzenia,
                            p_data = p.data_urodzenia,
                            p_id = p.ID_Pacjenta,
                            p_miasto = p.miejsce_zamieszkania,
                            p_adres = p.ulica,
                            p_kod = p.kod_pocztowy
                        };

            if ((string)cbPacjenciImie.SelectedItem != "Dowolne")
                query = query.Where(p => (string)p.p_imie == (string)cbPacjenciImie.SelectedItem);

            if ((string)cbPacjenciNazwisko.SelectedItem != "Dowolne")
                query = query.Where(p => (string)p.p_nazwisko == (string)cbPacjenciNazwisko.SelectedItem);

            if ((string)cbPacjenciMiasto.SelectedItem != "Dowolne")
                query = query.Where(p => (string)p.p_miasto == (string)cbPacjenciMiasto.SelectedItem);

            if ((string)cbPacjenciLekarz.SelectedItem != "Dowolny")
            {
                query = query.Where(l => (string)l.p_lekarz == (string)cbPacjenciLekarz.SelectedItem);
                dgvPacjenci.Columns["p_lekarz"].Visible = true;
            }
            else
                dgvPacjenci.Columns["p_lekarz"].Visible = false;

            if ((string)cbPacjenciWiek.SelectedItem != "Dowolny")
            {
                string value = (string)cbPacjenciWiek.SelectedItem;
                if (value == "Powyżej")
                {
                    query = query.Where(p => DateTime.Now.Year - p.p_data.Value.Year >= 101);
                }
                else
                {
                    try
                    {
                        var split = value.Split('-');
                        int dol = Convert.ToInt32(split[0]);
                        int gora = Convert.ToInt32(split[1]);
                        query = query.Where(p => DateTime.Now.Year - p.p_data.Value.Year >= dol);
                        query = query.Where(p => DateTime.Now.Year - p.p_data.Value.Year <= gora);
                    }
                    catch
                    {
                        MessageBox.Show("Nie udało się rozbić wieku na dwie liczby");
                    }
                }
            }
            try
            {
                dgvPacjenci.Columns["p_lekarz"].Visible = true;
                dgvPacjenci.DataSource = query.ToList();
            }
            catch{}
           
        }
        private void bPacjenciSzukaj_Click(object sender, EventArgs e)
        {
            konstuujFiltrPacjentow();
        }
        private void bPacjenciWyczysc_Click(object sender, EventArgs e)
        {
            ustawWartoscDomyslnaFiltrowPacjentow();
        }
        private void cmsPacjenci_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DodajPacjenta window = new DodajPacjenta();
            window.ShowDialog();
        }
        #endregion

        #region Wizyty
        public void wyswietlWizyty()
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                var wizyty = from w in dc.Wizyty
                             join p in dc.Pacjenci on w.ID_Pacjenta equals p.ID_Pacjenta
                             join l in dc.Lekarze on w.ID_Lekarza equals l.ID_Lekarza
                             orderby w.data descending, w.czas descending
                             select new
                             {
                                 w_data = w.data,
                                 w_godzina = w.czas,
                                 w_imie = p.imie,
                                 w_id = w.ID_Wizyty,
                                 w_nazwisko = p.nazwisko,
                                 w_odbyta = w.czy_odbyta,
                                 w_lekarz = l.nazwisko + " " + l.imie
                             };
                dgvWizyty.DataSource = wizyty.ToList();
            }
        }
        private void ustawWartoscDomyslnaFiltrowWizyt()
        {
            cbWizytyData.SelectedIndex = 0;
            cbWizytyLekarz.SelectedIndex = 0;
            rbWizytyWszystkie.Checked = true;
        }
        private void wczytajDaneDoFiltrowWizyt()
        {
            wczytajLekarzyWizyt(); 
            ustawWartoscDomyslnaFiltrowWizyt();
        }
        private void wczytajLekarzyWizyt()
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                var lekarze = from s in dc.Lekarze
                              orderby s.nazwisko ascending
                              select new
                              {
                                  imie = s.imie,
                                  nazwisko = s.nazwisko
                              };
                foreach (var lekarz in lekarze)
                    cbWizytyLekarz.Items.Add(String.Format("{0} {1}", lekarz.nazwisko, lekarz.imie));
            }
        }
        private void konstuujFiltrWizyt()
        {
            using (var dc = new EntitiesPrzychodnia())
            {

                var query = from p in dc.Pacjenci
                            join w in dc.Wizyty on p.ID_Pacjenta equals w.ID_Pacjenta into a
                            from w in a.DefaultIfEmpty()
                            join l in dc.Lekarze on w.ID_Lekarza equals l.ID_Lekarza into b
                            from l in b.DefaultIfEmpty()
                            orderby w.data descending, w.czas ascending
                            select new
                            {
                                w_lekarz = l.nazwisko + " " + l.imie,
                                w_imie = p.imie,
                                w_nazwisko = p.nazwisko,
                                w_godzina = w.czas,
                                w_data = w.data,
                                w_odbyta = w.czy_odbyta
                            };

                if ((string)cbWizytyLekarz.SelectedItem != "Dowolny")
                    query = query.Where(l => (string)l.w_lekarz == (string)cbWizytyLekarz.SelectedItem);

                if (rbWizytyOdbyte.Checked) {
                    query = query.Where(l => l.w_odbyta == true);
                }
                else if (rbWizytyNieodbyte.Checked)
                {
                    query = query.Where(l => l.w_odbyta == false);
                }


                if ((string)cbWizytyData.SelectedItem != "Dowolna") {
                    string value = (string)cbWizytyData.SelectedItem;
                    DateTime tydzienTemu = DateTime.Today.AddDays(-7);
                    DateTime wczoraj = DateTime.Today.AddDays(-1);
                    DateTime dwaTygodnieTemu = DateTime.Today.AddDays(-14);
                    DateTime miesiacTemu = DateTime.Today.AddDays(-30);
                    DateTime dwaMiesiaceTemu = DateTime.Today.AddDays(-60);
                    DateTime polRokuTemu = DateTime.Today.AddDays(-364 / 2);
                    DateTime rokTemu = DateTime.Today.AddDays(-365);
                    switch (value)
                    {
                        case "Dzisiaj":
                            query = query.Where(l => DateTime.Today == l.w_data.Value);
                            break;
                        case "Wczoraj":
                           
                            query = query.Where(l => l.w_data.Value == wczoraj);
                            break;
                        case "Ten tydzień":
                            
                            query = query.Where(l => l.w_data.Value > tydzienTemu);
                            query = query.Where(l => l.w_data.Value < DateTime.Now);
                            break;
                        case "Poprzedni tydzień":
                            query = query.Where(l => l.w_data.Value > dwaTygodnieTemu);
                            query = query.Where(l => l.w_data.Value < tydzienTemu);
                            break;
                       case "Ten miesiąc":
                            query = query.Where(l => l.w_data.Value > miesiacTemu);
                            query = query.Where(l => l.w_data.Value < DateTime.Now);
                            break;
                        case "Poprzedni miesiąc":                     
                            query = query.Where(l => l.w_data.Value > dwaMiesiaceTemu);
                            query = query.Where(l => l.w_data.Value < miesiacTemu);
                            break;
                        case "Pół roku":                         
                            query = query.Where(l => l.w_data.Value > polRokuTemu);
                            query = query.Where(l => l.w_data.Value < DateTime.Now);
                            break;
                        case "Rok":                     
                            query = query.Where(l => l.w_data.Value > rokTemu);
                            query = query.Where(l => l.w_data.Value < DateTime.Now);
                            break;
                        case "Więcej niż rok":
                            query = query.Where(l => l.w_data.Value < rokTemu);
                            break;
                        case "Zaplanowane":
                            query = query.Where(l => l.w_data.Value > DateTime.Now);
                            break;
                    }
                
                }


                dgvWizyty.DataSource = query.ToList();

            }

        }
        private void bWizytySzukaj_Click(object sender, EventArgs e)
        {
            konstuujFiltrWizyt();
            ustawStatus(dgvWizyty);
        }

        private void bWizytyWyczysc_Click(object sender, EventArgs e)
        {
            ustawWartoscDomyslnaFiltrowWizyt();
        }
        private void bWizytyDodaj_Click(object sender, EventArgs e)
        {
            DodajWizyte window = new DodajWizyte();
            window.ShowDialog();
        }
        private void bWizytyPrzeloz_Click(object sender, EventArgs e)
        {
            PrzelozWizyte window = new PrzelozWizyte(wizyta_id);
            window.ShowDialog();
        }
        #endregion

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OProgramie window = new OProgramie();
            window.Show();
        }

        private void statystykiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statystyki window = new Statystyki();
            window.Show();
        }


        private void ustawStatus(DataGridView dgv) {
            int liczba = dgv.Rows.Count;
            this.status.Text = String.Format("Liczba rekordów: {0}",liczba);
        
        }

    }
}
