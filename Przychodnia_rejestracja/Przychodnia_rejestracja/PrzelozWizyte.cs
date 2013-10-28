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
    public partial class PrzelozWizyte : Form
    {

        int id;
        public PrzelozWizyte(int id)
        {
            this.id = id;
            InitializeComponent();

           

        }
        private void przelozWizyte() {
            using (var dc = new EntitiesPrzychodnia())
            {
                var wizyta = from w in dc.Wizyty
                             where w.ID_Wizyty == id
                             select w;

                wizyta.First().data = nowaData.Value;
                wizyta.First().czas = new TimeSpan(nowaGodzina.Value.TimeOfDay.Hours, nowaGodzina.Value.TimeOfDay.Minutes, 00);
                try 
                {
                    dc.SaveChanges();
                }
                catch (Exception e) { }
            }
        }

        void aktywujDodaj() {
            dodaj.Enabled = ( !String.IsNullOrEmpty(data.Value.ToString())&&
                            !String.IsNullOrEmpty(godzina.Value.ToString())&&
                            !String.IsNullOrEmpty(nowaData.Value.ToString())&&
                            !String.IsNullOrEmpty(nowaGodzina.Value.ToString()));
        }

        private void anuluj_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            przelozWizyte();
            this.Close();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            aktywujDodaj();
        }

        private void PrzelozWizyte_Load(object sender, EventArgs e)
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                var wizyta = from w in dc.Wizyty
                             where w.ID_Wizyty == id
                             select w;
                Console.WriteLine(id);
                data.Value = (DateTime)wizyta.First().data;
                godzina.Value = Convert.ToDateTime(wizyta.First().czas.ToString());

            }
        }
    }
}
