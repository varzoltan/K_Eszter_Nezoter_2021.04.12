using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace K_Eszter_Nezoter_2021._04._12
{
    class Program
    {
        struct Adat
        {
            public string foglaltsag;
            public string kategoria;
        }
        static void Main(string[] args)
        {
            //1.feladat
            //Struktúra példányosítása
            Adat[] adatok  = new Adat[15];

            //Beolvasás
            StreamReader olvas = new StreamReader(@"E:\OneDrive - Kisvárdai SZC Móricz Zsigmond Szakgimnáziuma és Szakközépiskolája\Oktatas\Programozas\Jakab_Acs_Eszter\Erettsegi_feladatok\2014-oktober_uj\foglaltsag.txt");
            int n  =  0;
            while (!olvas.EndOfStream)
            {
                string sor  =  olvas.ReadLine();
                adatok[n].foglaltsag  = sor;
                n++;
            }
            olvas.Close();
            
            StreamReader olvas2 = new StreamReader(@"E:\OneDrive - Kisvárdai SZC Móricz Zsigmond Szakgimnáziuma és Szakközépiskolája\Oktatas\Programozas\Jakab_Acs_Eszter\Erettsegi_feladatok\2014-oktober_uj\kategoria.txt");
            n = 0;
            while (!olvas2.EndOfStream)
            {
                string sor = olvas2.ReadLine();
                adatok[n].kategoria = sor;
                n++;
            }
            olvas2.Close();
            Console.WriteLine("1.feladat\nBeolvasás kész!");

            //2.feladat
            Console.ReadKey();
        }
    }
}
