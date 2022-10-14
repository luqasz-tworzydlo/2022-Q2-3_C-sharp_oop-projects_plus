using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_kz1_osoba
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////
            //
            // Łukasz Tworzydło - nr albumu: gd29623 [projekt 1]
            //
            //////////////////////////////////////////////////
            Console.WriteLine("\n(1) Z1 => Wyświetlenie łącznie oraz osobno\n" +
                "imienia oraz nazwiska, jak i wypisanie wieku\n" +
                "[obliczonych lat za pomocą instrukcji w foreach] ;>\n");

            Nowa_Osoba();

            //////////////////////////////////////////////////

            Console.ReadKey();
        }
        static void Nowa_Osoba()
        {
            Osoba
                nowa_osoba = new Osoba("Missie", "Anaina");

            DateTime DataUrodzenia = new DateTime(2012, 3, 18);
            DateTime[] DataŚmierciNieśmierci =
            {
                new DateTime(2012, 3, 18),
                DateTime.Today,
                DateTime.Today.AddYears(1),
                DateTime.Today.AddYears(3),
                DateTime.Today.AddYears(7),
            };

            Console.WriteLine("Poznajcie " + nowa_osoba.Imię
                + ", której nazwisko \n"
                + "brzmi następująco: " + nowa_osoba.Nazwisko
                + "!" + " :>>>");

            Console.WriteLine("\nPełny zapis jej imienia i nazwiska"
                + "\nwygląda następująco ;>\n=> " + nowa_osoba.ImięNazwisko + " :>>>");

            Console.WriteLine("\nPoniżej jest wyświetlona ilość lat,\n" +
                "jakie miała " + nowa_osoba.Imię + " w roku 2012,\n" +
                "ile ma dzisiaj lat, ile będzie mieć za rok\n" +
                "ile będzie mieć za 3 lata oraz ile za 7 lat :>");

            foreach (DateTime wartości_dat in DataŚmierciNieśmierci)
            {
                TimeSpan nowa_wartość = wartości_dat - DataUrodzenia;
                int years = (((int)nowa_wartość.TotalDays) / 365);
                string dane_wyjściowe;
                if (DataUrodzenia.AddYears(years) <= wartości_dat)
                {
                    dane_wyjściowe = string.Format("=> {0} lat/a", years);
                    Console.WriteLine(dane_wyjściowe);
                }
                else
                {
                    dane_wyjściowe = string.Format("=> {0} lat/a", years - 1);
                    Console.WriteLine(dane_wyjściowe);
                }
            }
        }
    }
}
