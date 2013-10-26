using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorDanychLosowych
{

    enum Tabele {
        Wizyty,
        Recepty,
        LekiNaReceptach,
        Specjalnosci,
        Diagnozy
    };

    class Generator
    {
        Tabele tabela;
        int ile;
        Random rnd = new Random();

        // Stałe dolny i górny limit w bazie danych
        int lekarze0 = 1;
        int lekarze1 = 51;

        int pacjenci0 = 1;
        int pacjenci1 = 500;

        int specjalnosci0 = 1;
        int specjalnosci1 = 40;

        int rok0 = 1990;
        int rok1 = 2013;

        int godzina0 = 7;
        int godzina1 = 18;

        int choroby0 = 1;
        int choroby1 = 76;

        int wizyty0 =3;
        int wizyty1 =7512;

        public Generator(int ile, Tabele co) {
            this.ile = ile;
            this.tabela = co;
        }

        // losowa z przedzialu <a;b>
        private int losowa(int a, int b)
        {
            return rnd.Next(a, b + 1);
        }

        private int lekarze() {
            return losowa(lekarze0,lekarze1);   
        }

        private int pacjenci()
        {
            return losowa(pacjenci0, pacjenci1);
        }

        private int dzien(int miesiac) {
            int gora = 28;
            int [] po31 = {1,3,5,7,8,10,12};
            int [] po30 = {4,6,9,11};

            if (po30.Contains(miesiac))
                gora = 30;
            if (po31.Contains(miesiac))
                gora = 31;
            return losowa(1, gora);
        }

        private int specjalnosci()
        {
            return losowa(specjalnosci0, specjalnosci1);
        }

        private int Choroby()
        {
            return losowa(choroby0, choroby1);
        }

        private int Wizyty()
        {
            return losowa(wizyty0, wizyty1);
        }

        private string data() {
            int m = losowa(1,12);
            int d = dzien(m);
            int r = losowa(rok0,rok1);
            return String.Format("{0}-{1}-{2}",r,m,d);
        }

        private string data_wizyty()
        {
            int m = losowa(1, 12);
            int d = dzien(m);
            int r = losowa(rok1-3, rok1);
            return String.Format("{0}-{1}-{2}", r, m, d);
        }

        private bool PrawdaFalsz(double prwadopodobienstwo = 0.5)
        {
            int x = losowa(1, 99);
            if (x < prwadopodobienstwo * 100)
                return true;
            else
                return false;
        }

        private string godzina_wizyty()
        {
            int g = losowa(godzina0,godzina1);
            int m = losowa(0,11)*5;
            return String.Format("{0}:{1}:00", g, m);
        }

        private void generujSpecjalnosci() {
            for (int i = 0; i < ile; i++)
            {
                string output = String.Format("insert into LekarzSpecjalnosc (ID_Lekarza, ID_Specjalnosci, data_nadania) values ('{0}','{1}','{2}');",lekarze(),specjalnosci(),data());
                Console.WriteLine(output);
            }
        }

        private void generujWizyty()
        {
            for (int i = 0; i < ile; i++)
            {
                string output = String.Format("insert into Wizyty (ID_Lekarza, ID_Pacjenta, data, czas, czy_odbyta) values ('{0}','{1}','{2}', '{3}', '{4}');", lekarze(), pacjenci(), data_wizyty(),godzina_wizyty(),PrawdaFalsz(0.83));
                Console.WriteLine(output);
            }
        }

        private void generujDiagnozy()
        {
            for (int i = 0; i < ile; i++)
            {
                string output = String.Format("insert into Diagnozy (ID_Wizyty, ID_Choroby) values ('{0}','{1}');", Wizyty(),Choroby());
                Console.WriteLine(output);
            }
        }

        public void generuj() {

            switch (tabela) { 
            
                case Tabele.Specjalnosci:
                    generujSpecjalnosci();
                    break;
                case Tabele.Wizyty:
                    generujWizyty();
                    break;
                case Tabele.Diagnozy:
                    generujDiagnozy();
                    break;
            
            }


        }

    }
}
