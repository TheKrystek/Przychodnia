﻿using System;
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
        int lekarz_id;
        int lekarstwo_id;
        int choroba_id;
        int swiadczenie_id;
        int specjalnosc_id;

        public MainWindow()
        {
            InitializeComponent();
            wyswietlLekarzy();
            wyswietlSwiadczenia();
            wyswietlChoroby();
            wyswietlSpecjalnosci();
            wyswietlLekarstwa();
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

        // Sprawdzanie poprawności formatu - Zdarzenie
        private void SprawdzFormat_Tekst(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            switch (tb.Name)
            {
                case "tbKoszt":
                    this.bDodajSwiadczenie.Enabled = PoprawnyFormat_Pieniadze(tb.Text);
                    break;
                case "tbLekCena":
                    this.bLekDodaj.Enabled = PoprawnyFormat_Pieniadze(tb.Text);
                    break;
                case "tbSwiadczenia":
                    this.bDodajSwiadczenie.Enabled = PoprawnyFormat_Tekst(tb.Text, true);
                    break;
                case "tbChoroba":
                    this.bChDodaj.Enabled = PoprawnyFormat_Tekst(tb.Text, true);
                    break;
                case "tbSpecjalnosc":
                    this.bChDodaj.Enabled = PoprawnyFormat_Tekst(tb.Text, true);
                    break;
                case "tbLekarstwo":
                    this.bLekDodaj.Enabled = PoprawnyFormat_Tekst(tb.Text, true);
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
                        this.choroba_id = Convert.ToInt32(dgvChoroby.Rows[id].Cells["ch_id"].Value.ToString());
                    }
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

                        if (ulotka_xml.HasElements)
                        if (ulotka_xml.Element("podmiot").Value != null)
                            tbLekPodmiot.Text = ulotka_xml.Element("podmiot").Value;

                        if (ulotka_xml.HasElements)
                        if (ulotka_xml.Element("przeciwwskazania").Value != null)
                            tbLekPrzeciwwskazania.Text = ulotka_xml.Element("przeciwwskazania").Value;
                        
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
                        Console.WriteLine(e);
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
            //if (!String.IsNullOrEmpty(tbLekarstwo.Text))
                ulotka.Add(new XElement("nazwa", tbLekarstwo.Text));
            //if (!String.IsNullOrEmpty(tbLekPodmiot.Text))
                ulotka.Add(new XElement("podmiot", tbLekPodmiot.Text));
            //if (!String.IsNullOrEmpty(tbLekPrzeciwwskazania.Text))
                ulotka.Add(new XElement("przeciwwskazania", tbLekPrzeciwwskazania.Text));
            //if (!String.IsNullOrEmpty(tbLekDawkowanie.Text))
                ulotka.Add(new XElement("dawkowanie",tbLekDawkowanie.Text));


            dodajDoUlotki("sklad", "substancja", tbLekSklad.Text,ref ulotka);
            dodajDoUlotki("opakowania", "opakowanie", tbLekOpakowania.Text, ref ulotka);
            dodajDoUlotki("zalecenia", "zalecenie", tbLekZalecenia.Text, ref ulotka);
            dodajDoUlotki("niepozadane", "dzialanie", tbLekNiepozadane.Text, ref ulotka);
            return ulotka;
        }


        #endregion

    }
}
