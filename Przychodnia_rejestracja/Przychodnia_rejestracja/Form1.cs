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



namespace Przychodnia_rejestracja
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            wyswietlLekarzy();

        }
            
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




    }
}
