using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_kz3_wektor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////
            //
            // Łukasz Tworzydło - nr albumu: gd29623 [projekt 3]
            //
            //////////////////////////////////////////////////
            Console.WriteLine("\n(3) Z3 => Operacje na wektorach ;>");

            Test_Wektora_Ogólnego();

            Console.WriteLine("HI");

            //////////////////////////////////////////////////

            Console.ReadKey();
        }
        static void Test_Wektora_Ogólnego()
        {
            Wektor
                v = new Wektor(1, 2),
                w = new Wektor(3, 4),
                ss = Wektor.Suma(v, w);

            Console.WriteLine("Iloczyn skalarny dla dwóch wektorów, czyli:\n" +
                "v o wymiarze (" + v.Wymiar + ") oraz dla w o wymiarze (" + w.Wymiar + ") wynosi: ");
            Console.WriteLine(
                $"v = {Wektor.IloczynSkalarny(v, w)}");

            Console.WriteLine("Po dodaniu dwóch wektorów ich rozmiar wygląda następująco: \n" +
                $"|ss| = {ss.Długość}");

            Console.WriteLine("Natomiast iloczyn dla ss (czyli sumy dwóch wektorów v i w) oraz wektora w wynosi: ");
            Console.WriteLine(
                $"w = {Wektor.IloczynSkalarny(ss, w)};");

        }

    }
}
