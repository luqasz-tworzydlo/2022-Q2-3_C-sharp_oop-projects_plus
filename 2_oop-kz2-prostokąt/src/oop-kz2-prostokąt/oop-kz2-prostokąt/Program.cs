using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_kz2_prostokąt
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////
            //
            // Łukasz Tworzydło - nr albumu: gd29623 [projekt 2]
            //
            //////////////////////////////////////////////////
            Console.WriteLine("\n(2) Z2 => Wyświetlenie wybranych\n" +
                "arkuszy papieru, zgodnie z wprowadzonymi danymi\n" +
                "[wymiary dla arkuszy A, B, jak i również C] ;>");

            Wybrane_Arkusze();

            //////////////////////////////////////////////////

            Console.ReadKey();
        }
        static void Wybrane_Arkusze()
        {
            Prostokąt
                P1_1 = new Prostokąt("A4"),
                P1_2 = new Prostokąt("A5"),
                P1_3 = new Prostokąt("A9"),

                P2_1 = new Prostokąt("B4"),
                P2_2 = new Prostokąt("B5"),
                P2_3 = new Prostokąt("B9"),

                P3_1 = new Prostokąt("C4"),
                P3_2 = new Prostokąt("C5"),
                P3_3 = new Prostokąt("C9"),

                P4 = new Prostokąt(30, 21);

            Console.WriteLine("\n\nWprowadź wymiar arkusza [zgodny z normą ISO 216" +
                "\ndla szeregu A i B oraz ISO 269 dla szeregu C]:\n");
            string wwa = Convert.ToString(Console.ReadLine());
            Prostokąt
                P5 = new Prostokąt(wwa);
        }
    }
}
