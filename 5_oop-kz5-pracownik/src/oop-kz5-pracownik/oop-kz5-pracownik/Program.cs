using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_kz5_pracownik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////
            //
            // Łukasz Tworzydło - nr albumu: gd29623 [projekt 5]
            //
            //////////////////////////////////////////////////
            Console.WriteLine("\n(5) Z5 => Operacje na typach Pracownik oraz ZbiórPodwładnyhch ;>\n");

            Console.WriteLine("/ / / = A = / / /\n");
            Pracownicy_Podwładni_1();

            Console.WriteLine("\n/ / / = B = / / /\n");
            Pracownicy_Podwładni_2();

            //////////////////////////////////////////////////

            Console.ReadKey();
        }
        static void Pracownicy_Podwładni_1()
        {
            Pracownik
                z1 = new Pracownik() { Imię = "Wojciech", Nazwisko = "Angel" },
                z2 = new Pracownik() { Imię = "Aleksander", Nazwisko = "Toarski", BezpośredniPrzełożony = z1 },
                z3 = new Pracownik() { Imię = "Miriana", Nazwisko = "Rominska"}
                ;
            z1.Podwładni.Add(z3);

            Console.WriteLine(
                $"=> Pracownik {z2} ma następującego przełożonego: {z2.BezpośredniPrzełożony}");
            Console.WriteLine(
                $"=> Pracownik {z3} ma w tymże przypadku przełożonego: {z3.BezpośredniPrzełożony}\n");
            foreach (Pracownik pracownik in z1.Podwładni.Zbiór)
                Console.WriteLine(
                    $"=> Natomiast przełożony, czyli {z1} ma pracownika: {pracownik}"
                    );
        }
        static void Pracownicy_Podwładni_2()
        {

            Pracownik
                bp1 = new Pracownik() { Imię = "Wojciech", Nazwisko = "Angel" },
                bp2 = new Pracownik() { Imię = "Renata", Nazwisko = "Light" };
            Pracownik
                p1 = new Pracownik() { Imię = "Martyna", Nazwisko = "Fiołkowska", BezpośredniPrzełożony = bp1 },
                p2 = new Pracownik() { Imię = "Filip", Nazwisko = "Malinsky", BezpośredniPrzełożony = bp2 },
                p3 = new Pracownik() { Imię = "Sebastian", Nazwisko = "Jankosk" },
                p4 = new Pracownik() { Imię = "Lucine", Nazwisko = "Dehlas" };

            bp2.Podwładni.Add(p3);

            Console.WriteLine("W pierwszym kwartale 2022 roku sytuacja przełożonych i podwładnych wyglądała następująco:");

            foreach (Pracownik pracownik in bp1.Podwładni.Zbiór)
                Console.WriteLine(
                    $"=> Przełożony, czyli {bp1} miał/a następującego podwładnego pracownika: {pracownik}");
            foreach (Pracownik pracownik in bp2.Podwładni.Zbiór)
                Console.WriteLine(
                    $"=> Przełożona, czyli {bp2} miał/a następującego podwładnego pracownika: {pracownik}");

            bp2.Podwładni.Remove(p3);
            bp1.Podwładni.Add(p3);
            bp1.Podwładni.Add(p4);

            Console.WriteLine("\nJednakże po pewnych zmianach, jakie nastąpiły w drugim kwartale 2022 roku, obecnie ma następującą formę:");

            foreach (Pracownik pracownik in bp1.Podwładni.Zbiór)
                Console.WriteLine(
                    $"=> Przełożony, czyli {bp1} ma następującego podwładnego pracownika: {pracownik}");
            foreach (Pracownik pracownik in bp2.Podwładni.Zbiór)
                Console.WriteLine(
                    $"=> Przełożona, czyli {bp2} ma następującego podwładnego pracownika: {pracownik}");

            Console.WriteLine("\nPodsumowując, od strony pracowników obecnie ich sytuacja wyglądała następująco");
            Console.WriteLine(
                $"<1> {p1} ma następującego przełożonego: {p1.BezpośredniPrzełożony}");
            Console.WriteLine(
                $"<2> {p2} ma następującego przełożonego: {p2.BezpośredniPrzełożony}");
            Console.WriteLine(
                $"<3> {p3} ma następującego przełożonego: {p3.BezpośredniPrzełożony}");
            Console.WriteLine(
                $"<4> {p4} ma następującego przełożonego: {p4.BezpośredniPrzełożony}");
        }
    }
}
