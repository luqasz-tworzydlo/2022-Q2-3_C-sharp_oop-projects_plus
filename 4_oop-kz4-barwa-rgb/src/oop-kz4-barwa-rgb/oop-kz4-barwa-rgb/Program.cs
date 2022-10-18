using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_kz4_barwa_rgb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////
            //
            // Łukasz Tworzydło - nr albumu: gd29623 [projekt 4]
            //
            //////////////////////////////////////////////////
            Console.WriteLine("\n(4) Z4 => Podstawy dziedziczenia - operacje na barwach ;>\n");

            // RGB();
            // Colors();
            ARGB();

            //////////////////////////////////////////////////

            Console.ReadKey();
        }
        static void RGB()
        {
            Barwa barwa = new Barwa();
        }
        static void Colors()
        {
            Barwa12 b12 = new Barwa12();
            Console.WriteLine(b12);
        }
        static void ARGB()
        {
            BarwaPółprzezroczysta BarwaP1B = new BarwaPółprzezroczysta();
            Console.WriteLine(BarwaP1B);
        }
    }
}
