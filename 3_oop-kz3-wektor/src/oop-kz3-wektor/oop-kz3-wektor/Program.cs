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
            Console.WriteLine("\n(3.1) Z3 => Operacje na wektorach ;>" +
                "\n[ wymiar wektora, długość wektora,\nsuma wektorów, iloczyn skalarny wektorów ]\n");

            Wektor_Wymiary();

            Console.WriteLine("\n/// /// /// /// /// /// /// /// /// /// /// ///");

            Console.WriteLine("\n(3.2) Z3 => Operacje na wektorach ;>" +
                "\n[ dodawanie wektorów, odejmowanie wektorów,\nmnożenie wektorów, dzielenie wektorów ]");

            Operacje_Wektorów();

            //////////////////////////////////////////////////

            Console.ReadKey();
        }
        static void Wektor_Wymiary()
        {
            Wektor
                v = new Wektor(1, 3),
                w = new Wektor(5, 7),
                s = Wektor.Suma(v, w);

            Console.WriteLine("Nasze wektory, na których będziemy\nwykonywać różne operacje to \"v\" oraz \"w\" :>\n");

            Console.WriteLine("Iloczyn skalarny dla naszych dwóch wektorów, czyli:\n" +
                "v o wymiarze (" + v.Wymiar + ") oraz dla w o wymiarze (" + w.Wymiar + ") wynosi: " +
                $"v = {Wektor.IloczynSkalarny(v, w)}\n");

            Console.WriteLine("Po dodaniu dwóch wektorów ich rozmiar wygląda\nnastępująco: " +
                $"|s| = {s.Długość}\n");

            Console.WriteLine("Natomiast iloczyn dla s (czyli sumy dwóch\nwektorów v i w) oraz wektora w wynosi: " + 
                $"w = {Wektor.IloczynSkalarny(s, w)};");
        }
        static void Operacje_Wektorów()
        {
            Wektor
                v = new Wektor() { X = 4, Y = -4 },
                w = new Wektor() { X = -9, Y = 9 },
                s = v + w, // doddawanie wektorów
                v2 = v * 2, // mnożenie przez skalar
                v3 = 3 * v, // mnożenie przez skalar
                m1 = -w, // odwrócenie wartości
                m2 = -v, // odwrócenie wartości
                r = v - w, // odejmowanie wektorów
                vd2 = v / 2, // dzielenie przez skalar
                vd4 = 4 / v, // dzielenie przez skalar
                wd3 = w / 3, // dzielenie przez skalar
                wd9 = 9 / w // dzielenie przez skalar
                ;

            Console.WriteLine("\nKolejne, inne operacje na wektorach :>");

            Console.WriteLine("\nNasz pierwszy wektor początkowy to: " + $"v = {v}");
            Console.WriteLine("\nZ kolei nasz drugi wektor początkowy to: " + $"w = {w}");

            Console.WriteLine("\n<dodawanie> => nowy wektor po wykonaniu operacji dodawania: " + $"v+w = {s}");

            Console.WriteLine("\n=> nasz nowy operator po odwróceniu wartości w wynosi: " + $"-w = {m1}");
            Console.WriteLine("=> nasz nowy operator po odwróceniu wartości v wynosi: " + $"-v = {m2}");
            Console.WriteLine("\n<odejmowanie> => nasz nowy operator po odjęciu dwóch wektorów wynosi: " + $"v-w = {r}");

            Console.WriteLine("\n<mnożenie> => po pierwszej operacji mnożenia nowy wektor wynosi: " + $"v*2 = {v2}");
            Console.WriteLine("<mnożenie> => po drugiej operacji mnożenia nowy wektor wynosi: " + $"3*v = {v3}");

            Console.WriteLine("\n<dzielenie> => po pierwszej operacji dzielenia nowy wektor wynosi: " + $"v/2 = {vd2}");
            Console.WriteLine("<dzielenie> => po drugiej operacji dzielenia nowy wektor wynosi: " + $"4/v = {vd4}");
            Console.WriteLine("<dzielenie> => po trzeciej operacji dzielenia nowy wektor wynosi: " + $"w/3 = {wd3}");
            Console.WriteLine("<dzielenie> => po czwartej operacji dzielenia nowy wektor wynosi: " + $"9/w = {wd9}");
        }
    }
}
