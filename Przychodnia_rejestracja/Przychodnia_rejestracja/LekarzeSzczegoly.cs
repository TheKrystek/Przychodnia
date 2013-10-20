﻿using System;
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
    public partial class LekarzeSzczegoly : Form
    {
        private int index;
        public bool szczegoly = true;
        public LekarzeSzczegoly(int i)
        {
            InitializeComponent();
            index = i;

        }

        public void wypenijDanymi(){
            using (var dc = new EntitiesPrzychodnia()){
                var lekarz = from c in dc.Lekarze
                              where c.ID_Lekarza == this.index
                              select new
                              {
                                  imie = c.imie,
                                  nazwisko = c.nazwisko,
                                  miejsce_ur = c.miejsce_urodzenia,
                                  data_ur = c.data_urodzenia,
                                  id = c.ID_Lekarza,
                                  miescje_zam = c.miejsce_zamieszkania,
                                  adres = c.ulica,
                                  kod_pocztowy = c.kod_pocztowy,
                                  pesel = c.PESEL
                              };

                this.imie.Text = lekarz.First().imie;
                this.nazwisko.Text = lekarz.First().nazwisko;
                this.data_ur.Text = lekarz.First().data_ur.ToString();
                this.miejsce_ur.Text = lekarz.First().miejsce_ur;
                this.miejsce_zam.Text = lekarz.First().miescje_zam;
                this.ulica.Text = lekarz.First().adres;
                this.kod.Text = lekarz.First().kod_pocztowy;
                this.pesel.Text = lekarz.First().pesel;
            }   
        }

        public void wypenijDanymiSpecjalnosci()
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                var specjalnosci = from ls in dc.LekarzSpecjalnosc
                                   join s in dc.Specjalnosci on ls.ID_Specjalnosci equals s.ID_Specjalnosci
                                   where ls.ID_Lekarza == this.index
                                   select new
                                   {
                                       specjalnosc = s.nazwa,
                                       data_nad = ls.data_nadania
                                   };
                dgvSpecjalnosci.DataSource = specjalnosci.ToList();
            }
        }

        public void wypenijDanymiWizyty()
        {
            using (var dc = new EntitiesPrzychodnia())
            {
                var wizyty = from w in dc.Wizyty   
                                   where w.ID_Lekarza == this.index
                                   join p in dc.Pacjenci on w.ID_Pacjenta equals p.ID_Pacjenta
                                   orderby w.data descending , w.czas descending
                                   select new
                                   {
                                       data = w.data,
                                       godzina = w.czas,
                                       wimie = p.imie,
                                       wnazwisko = p.nazwisko, 
                                       odbyta = w.czy_odbyta
                                   };
                dgvWizyty.DataSource = wizyty.ToList();
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (szczegoly) {
                using (var dc = new EntitiesPrzychodnia()){
                    var lekarz = dc.Lekarze.Single(p => p.ID_Lekarza == index);

                    lekarz.imie = imie.Text;
                    lekarz.nazwisko = nazwisko.Text;
                    lekarz.data_urodzenia = Convert.ToDateTime(data_ur.Text);
                    lekarz.miejsce_urodzenia = miejsce_ur.Text;
                    lekarz.miejsce_zamieszkania = miejsce_zam.Text;
                    lekarz.PESEL = pesel.Text;
                    lekarz.ulica = ulica.Text;
                    lekarz.kod_pocztowy = kod.Text;
                    try { 
                        dc.SaveChanges();
                    }
                    catch{
                        MessageBox.Show("Nie udało się zaktualizować rekordu");
                    }
                }
            }
            else{
                using (var dc = new EntitiesPrzychodnia()){
                    var lekarz = new Lekarze();
                    lekarz.imie = imie.Text;
                    lekarz.nazwisko = nazwisko.Text;
                    try {
                        lekarz.data_urodzenia = Convert.ToDateTime(data_ur.Text);
                    }
                    catch {
                        MessageBox.Show("Błędny format daty - spróbuj jescze raz!");
                    }
                    lekarz.miejsce_urodzenia = miejsce_ur.Text;
                    lekarz.miejsce_zamieszkania = miejsce_zam.Text;
                    lekarz.PESEL = pesel.Text;
                    lekarz.ulica = ulica.Text;
                    lekarz.kod_pocztowy = kod.Text;                    
                    try
                    {
                        dc.Lekarze.Add(lekarz);
                        dc.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Nie udało się dodać rekordu");
                    }
                }
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LekarzeSzczegoly_Load(object sender, EventArgs e)
        {
            if (szczegoly)
            {
                wypenijDanymi();
                this.Text = String.Format("{0} {1} - Szczegóły", imie.Text, nazwisko.Text);
                button.Text = "Zapisz";
                wypenijDanymiSpecjalnosci();
                wypenijDanymiWizyty();
            }
            else
            {
                this.Text = "Dodaj Lekarza";
                button.Text = "Dodaj";
                this.Height = this.Height - panel1.Height;
                panel1.Visible = false;
            }
        }



        



    }
}

    
