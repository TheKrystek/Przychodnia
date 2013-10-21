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
            this.index =  id;
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
                    lekarzSpecjalnosc.ID_LekarzSpecjalnosc = id_specjalnosci;
                    lekarzSpecjalnosc.data_nadania = dataPicker.Value;
                  
                    try
                    {
                        dc.LekarzSpecjalnosc.Add(lekarzSpecjalnosc);
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

        private void DodajSpecjalnosc_Load(object sender, EventArgs e)
        {
            if (lekarz)
            {

            }
            else {
                this.Height -= panel_lakarz.Height;
                panel_lakarz.Visible = false;

            }
            wypenijDanymiSpecjalnosci();
        }








    }
}
