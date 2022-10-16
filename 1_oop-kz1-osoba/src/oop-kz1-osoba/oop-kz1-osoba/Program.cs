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
                "imienia oraz nazwiska, jak i wypisanie wieku ;>\n");

            Nowa_Zagadka();

            Console.WriteLine("\n... kontynuując ...\n");

            Nowa_Osoba();

            //////////////////////////////////////////////////

            Console.ReadKey();
        }
        static void Nowa_Zagadka()
        {
            Osoba
                osoba_zagadka = new Osoba("Vanessa", "Cardui");

            Console.WriteLine("Czy wiesz, że " + osoba_zagadka.ImięNazwisko + " to owad z rzędu motyli? :>");

            Osoba s = new Osoba()
            {
                DataUrodzenia = DateTime.Parse("18.03.2022"),
                DataŚmierci = DateTime.Parse("28.03.2022"),
            };

            Console.WriteLine("Niestety krótko żyją motylki, zaledwie od 15 do 29 dni :'<\n");

            Console.WriteLine(
                "W naszym przypadku " +
                osoba_zagadka.Imię + " żyła zaledwie " +
                s.wiek_ilośćDni.Value.Days + " dni :<<<"
                );
        }
        static void Nowa_Osoba()
        {
            Osoba
                nowa_osoba = new Osoba("Missie", "Anaina");

            Console.WriteLine("Poznajcie " + nowa_osoba.Imię
                + ", której nazwisko \n"
                + "brzmi następująco: " + nowa_osoba.Nazwisko
                + "!" + " :>>>");

            Console.WriteLine("\nPełny zapis jej imienia i nazwiska"
                + "\nwygląda następująco ;>\n=> " + nowa_osoba.ImięNazwisko + " :>>>");


            DateTime DataUrodzenia = new DateTime(2012, 3, 18);
            DateTime[] DataŚmierciNieśmierci =
            {
                new DateTime(2012, 3, 18),
                DateTime.Today,
                DateTime.Today.AddYears(1),
                DateTime.Today.AddYears(3),
                DateTime.Today.AddYears(7),
            };

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
