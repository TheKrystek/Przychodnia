using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorDanychLosowych
{
    class Program
    {



        static void Main(string[] args)
        {
            //Generator g = new Generator(70,Tabele.Specjalnosci);
            //Generator g = new Generator(6000,Tabele.Wizyty);
            Generator g = new Generator(4400, Tabele.Diagnozy);



            g.generuj();


            Console.ReadKey();
        }
    }
}
