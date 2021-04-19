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
            Console.WriteLine("2.feladat");
            Console.Write("Kérem adja meg a sor számát: ");
            string sor1 = Console.ReadLine();
            Console.Write("Kérem adja meg a szék számát: ");
            string szek = Console.ReadLine();
            int szek1 = int.Parse(szek);
            int sor2 = int.Parse(sor1);          
            /*for (int i = 0; i<n;i++)
            {
                if (i == int.Parse(sor1)-1)
                {
                    if (adatok[i].foglaltsag.Substring(szek1-1,1) == "o")
                    {
                        Console.WriteLine("Az adott hely szabad!");
                    }
                    else
                    {
                        Console.WriteLine("Az adott hely foglalt!");
                    }
                }
            }*/
            //Szebbik megoldás
            if (adatok[sor2 - 1].foglaltsag.Substring(szek1-1,1) == "o")
            {
                Console.WriteLine("Az adott hely szabad!");
            }
            else
            {
                Console.WriteLine("Az adott hely foglalt!");
            }

            //3.feladat
            int foglalt_helyek = 0;
            const int osszes_ulohely = 15 * 20;
            for (int i = 0;i<n;i++)
            {
                for (int j = 0;j<20;j++)
                {
                    if (adatok[i].foglaltsag[j] == 'x')
                    {
                        foglalt_helyek++;
                    }
                }
            }
            Console.WriteLine($"3.feladat\nAz előadásra eddig {foglalt_helyek} jegyet adtak el, ez a nézőtér {((double)foglalt_helyek / osszes_ulohely * 100).ToString("0")}%-a.");
            Console.ReadKey();
        }
    }
}
