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
    public partial class DodajSpecjalnosc : Form
    {
        int index;
        public bool lekarz = false;
        public DodajSpecjalnosc(int id = -1)
        {
            this.index = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodaj_button_Click(object sender, EventArgs e)
        {
            this.Close();
            if (lekarz)
            {

            }
            else
            {
                using (var dc = new EntitiesPrzychodnia())
                {
                    var specjalnosci = from s in dc.Specjalnosci
                                       where s.nazwa == cbSpecjalnosci.Text
                                       select new
                                       {
                                           id = s.ID_Specjalnosci
                                       };
                    int id_specjalnosci = specjalnosci.First().id;
                    var lekarzSpecjalnosc = new LekarzSpecjalnosc();
                    lekarzSpecjalnosc.ID_Lekarza = index;
                    lekarzSpecjalnosc.ID_Specjalnosci = id_specjalnosci;
                    lekarzSpecjalnosc.data_nadania = dataPicker.Value;
                    try
                    {
                        dc.LekarzSpecjalnosc.Add(lekarzSpecjalnosc);
                        dc.SaveChanges();
                    }
                    catch {}
                }
            }
        }

        public void wypenijDanymiSpecjalnosci()
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                var specjalnosci = from s in dc.Specjalnosci
                                   select new
                                   {
                                       specjalnosc = s.nazwa
                                   };
                foreach (var spec in specjalnosci)
                    cbSpecjalnosci.Items.Add(spec.specjalnosc);
            }
        }

        public void wypenijDanymiLekarze()
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                var lekarze = from l in dc.Lekarze
                                   select new
                                   {
                                       imie = l.imie,
                                       nazwisko = l.nazwisko
                                   };
                foreach (var lekarz in lekarze)
                    cbSpecjalnosci.Items.Add(lekarz.imie +" "+lekarz.nazwisko);
            }
        }

        private void DodajSpecjalnosc_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            if (lekarz)
            {

            }
            else
            {
                this.Height -= panel_lakarz.Height;
                panel_lakarz.Hide();
                panel1.Location = panel_lakarz.Location;

            }
            wypenijDanymiSpecjalnosci();
        }








    }
}
