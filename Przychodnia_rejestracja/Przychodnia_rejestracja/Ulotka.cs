using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Przychodnia_rejestracja
{
    public partial class Ulotka : Form
    {
        private const int EM_GETLINECOUNT = 0xba;
        [DllImport("user32", EntryPoint = "SendMessageA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int SendMessage(int hwnd, int wMsg, int wParam, int lParam);

        int id;
        public Ulotka(int id)
        {
            this.id = id;
            InitializeComponent();
        }


        private void ustawWysokoscOkna() {

            int suma = 0;
            Control[] lista = {a,b,c,d,e,f,nazwa,przeciwwskazania,dawkowanie,zalecenia,sklad,podmiot,niepozadane,opakowania,panel1 };
            foreach (var element in lista)
                suma += element.Height;
            if (suma > this.Height)
            {
                ScrollBar vScrollBar1 = new VScrollBar();
                vScrollBar1.Dock = DockStyle.Right;
                panel2.Controls.Add(vScrollBar1);
            
            }

        }



        private void podmiot_TextChanged(object sender, EventArgs e)
        {
            
            RichTextBox rtb = (RichTextBox)sender;
            var numberOfLines = SendMessage(rtb.Handle.ToInt32(), EM_GETLINECOUNT, 0, 0);
            if (numberOfLines > 1)
                rtb.Height = (rtb.Font.Height + 2) * (numberOfLines - 1);
            else
                rtb.Height = (rtb.Font.Height + 2) * numberOfLines;
            ustawWysokoscOkna();
        }

        private void Ulotka_Load(object sender, EventArgs e)
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                var lekarstwo = from s in dc.Lekarstwa
                                where s.ID_Lekarstwa == this.id
                                select new
                                {
                                    lek_nazwa = s.nazwa,
                                    lek_ulotka = s.ulotka
                                };
                string ulotka = lekarstwo.First().lek_ulotka;
                if (!String.IsNullOrEmpty(ulotka))
                {
                    XElement ulotka_xml = XElement.Parse(ulotka);
                    try
                    {
                        nazwa.Text = lekarstwo.First().lek_nazwa;
                        if (ulotka_xml.Element("dawkowanie").Value != null)
                            dawkowanie.AppendText(ulotka_xml.Element("dawkowanie").Value);

                        if (ulotka_xml.Element("podmiot").Value != null)
                            podmiot.Text = ulotka_xml.Element("podmiot").Value;


                        if (ulotka_xml.Element("przeciwwskazania").Value != null)
                            foreach (var element in ulotka_xml.Element("przeciwwskazania").Elements())
                                przeciwwskazania.Text += "\t• " + (element.Value.ToString() + Environment.NewLine);

                        if (ulotka_xml.Element("sklad").Value != null)
                            foreach (var element in ulotka_xml.Element("sklad").Elements())
                                sklad.Text += "\t• " + (element.Value.ToString() + Environment.NewLine);

                        if (ulotka_xml.Element("zalecenia").Value != null)
                            foreach (var element in ulotka_xml.Element("zalecenia").Elements())
                                zalecenia.Text += "\t• " + (element.Value.ToString() + Environment.NewLine);

                        if (ulotka_xml.Element("niepozadane").Value != null)
                            foreach (var element in ulotka_xml.Element("niepozadane").Elements())
                                niepozadane.Text += "\t• " + (element.Value.ToString() + Environment.NewLine);

                        if (ulotka_xml.Element("opakowania").Value != null)
                            foreach (var element in ulotka_xml.Element("opakowania").Elements())
                                opakowania.Text += "\t• " + (element.Value.ToString() + Environment.NewLine);

                    }
                    catch 
                    {
                        MessageBox.Show("Ulotka zawiera niepoprawny XML (np. brakuje któregoś z pól)");
                    }
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
