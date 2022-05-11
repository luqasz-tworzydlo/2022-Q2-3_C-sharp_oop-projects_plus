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
            kz2_prostokąt
                P1_1 = new kz2_prostokąt("A4"),
                P1_2 = new kz2_prostokąt("A5"),
                P1_3 = new kz2_prostokąt("A9"),

                P2_1 = new kz2_prostokąt("B4"),
                P2_2 = new kz2_prostokąt("B5"),
                P2_3 = new kz2_prostokąt("B9"),

                P3_1 = new kz2_prostokąt("C4"),
                P3_2 = new kz2_prostokąt("C5"),
                P3_3 = new kz2_prostokąt("C9"),

                P3 = new kz2_prostokąt(30, 21);
        }
    }
}
