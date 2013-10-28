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

        private void dodaj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
