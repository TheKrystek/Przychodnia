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
        }
        

        // Wyswietl lekarzy w data grid view
        public void wyswietlLekarzy(){
            using (var dc = new  EntitiesPrzychodnia()){
                var lekarze = from c in dc.Lekarze select new { 
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

        public void wyswietlSwiadczenia()
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                var swiadczenia = from s in dc.Swiadczenia
                              select new
                              {
                                  s_id = s.ID_Swiadczenia,
                                  s_nazwa =s.nazwa,
                                  s_koszt = s.koszt
                              };
                dgvSwiadczenia.DataSource = swiadczenia.ToList();
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

        private void cmsLekarze_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            int index = dgvLekarze.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (index > -1)
            {
                int id = (int)dgvLekarze.Rows[index].Cells["id"].Value;

                if (item.Name == "lekarze_szczegoly"){
                    LekarzeSzczegoly win = new LekarzeSzczegoly(id);
                    win.ShowDialog();
                }
                else if (item.Name == "lekarze_dodaj") {
                    LekarzeSzczegoly win = new LekarzeSzczegoly(id);
                    win.szczegoly = false;
                    win.ShowDialog();
                }
                wyswietlLekarzy();
            }      
            
        }


        private bool sprawdzCzySwiadczeniaIstnieje(string nazwa, double koszt) {
            using (var dc = new EntitiesPrzychodnia())
            {
                var swiadczenia = from s in dc.Swiadczenia where 
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
                }
                else {
                    MessageBox.Show("Takie świadczenie już istnieje!");
                }
            }
            else {
                MessageBox.Show("Pola \"nazwa\" i \"koszt\" nie mogą być puste!");
            }
        }


        // Sprawdzanie poprawności formatu: pieniądze
        private bool PoprawnyFormat_Pieniadze(string text) {
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
            switch (tb.Name) { 
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
                    this.bDodajSwiadczenie.Enabled = PoprawnyFormat_Tekst(tb.Text,true);
                    break;
            }
        }


        private void ZamienMiejscami(Control first, Control second) {
            if (first.Visible)
            {
                first.Hide();
                second.Show();
                second.Location = first.Location;
            }
            else {
                second.Hide();
                first.Show();
                first.Location = second.Location;
            }
        }


        private void EdytujSwiadczenie() { 
            int id = dgvSwiadczenia.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (id >= 0) {
                tbSwiadczenia.Text = dgvSwiadczenia.Rows[id].Cells["s_nazwa"].Value.ToString();
                tbKoszt.Text = dgvSwiadczenia.Rows[id].Cells["s_koszt"].Value.ToString();
                // Zamien przyciski miejscami
                if (!bEdytujSwiadczenie.Visible)
                {
                    ZamienMiejscami(bDodajSwiadczenie, bEdytujSwiadczenie);
                    gbSwiadczenia.Text = "Dodaj świadczenie";
                    this.index = Convert.ToInt32(dgvSwiadczenia.Rows[id].Cells["s_id"].Value.ToString());
                }
            }
        }

        private void dgvRow_DoubleClicked(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = (DataGridView)sender;
                dgv.Rows[e.RowIndex].Selected = true;
                dgv.Focus();

                switch (dgv.Name) { 
                    case "dgvSwiadczenia":
                        EdytujSwiadczenie();
                        break;               
                }

            }
            catch { } 
        }

        private void bEdytujSwiadczenie_Click(object sender, EventArgs e)
        {
            using (var dc = new EntitiesPrzychodnia()){
                    var swiadczenie = dc.Swiadczenia.Single(s => s.ID_Swiadczenia == this.index);
                    swiadczenie.koszt = Convert.ToDouble(tbKoszt.Text);
                    swiadczenie.nazwa = tbSwiadczenia.Text;
                    try {
                        dc.SaveChanges();
                    }
                    catch {
                        MessageBox.Show("Nie udało się zaktualizować rekordu");
                    }
            }
            ZamienMiejscami(bDodajSwiadczenie, bEdytujSwiadczenie);
            gbSwiadczenia.Text = "Dodaj świadczenie";
            tbKoszt.Text = "";
            tbSwiadczenia.Text = "";

        }


    }
}
