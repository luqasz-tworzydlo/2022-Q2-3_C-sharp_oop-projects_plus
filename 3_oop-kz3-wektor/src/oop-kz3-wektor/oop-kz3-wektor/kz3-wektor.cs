using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_kz3_wektor
{
    internal class Wektor
    {
        readonly double[] współrzędne;
        public double this[byte indeks]
        {
            get { return współrzędne[indeks]; }
            set
            {
                switch (value)
                {
                    case double.NaN:
                    case double.PositiveInfinity:
                    case double.NegativeInfinity:
                        throw new Exception(
                            $"Niepoprawna wartość {value} na współrzędnej {indeks} wektora");
                    default:
                        współrzędne[indeks] = value;
                        break;
                }
            }
        }
        public byte Wymiar // zwracanie wartości wymiaru wektora
        {
            get { return (byte)współrzędne.Length; }
        }
        public double Długość // zwracanie wartości długości wektora
        {
            get { return Math.Sqrt( IloczynSkalarny(this, this) ); }
        }
        public Wektor(byte wymiar) // konstruktor nr 1 [może być zastąpiony w całości przez konstruktor nr 2]
        {
            współrzędne = new double[wymiar];
        }
        public Wektor(params double[] współrzędne) // konstruktor nr 2 [może być zastąpiony w całości przez konstruktor nr 1]
        {
            this.współrzędne = (double[])współrzędne.Clone();
        }
        public static double IloczynSkalarny(Wektor v, Wektor w) // obliczanie iloczynu skalarnego wektorów
        {
            if (v.Wymiar != w.Wymiar)
                return double.NaN;
            double suma = 0;

            for (byte indeks = 0; indeks < v.Wymiar; indeks++)
                suma += v.współrzędne[indeks] * w.współrzędne[indeks];

            return suma;
        }
        public static Wektor Suma(Wektor v, Wektor w) // obliczanie sumy wektorów
        {
            if (v.Wymiar != w.Wymiar)
                throw new Exception(
                    $"Niezgodne wymiary sumowanych wektorów {v.Wymiar} i {w.Wymiar}");

            Wektor nowy = new Wektor(v.Wymiar);
            for (byte indeks = 0; indeks < v.Wymiar; indeks++)
                nowy.współrzędne[indeks] = v.współrzędne[indeks] + w.współrzędne[indeks];

            return nowy;
        }

        public double
            X = 0,
            Y = 0;

        // poniżej jest operator zwracający nową instancję, będącą sumą wektorów
        static public Wektor operator +(Wektor v, Wektor w)
        {
            return new Wektor()
            {
                X = v.X + w.X,
                Y = v.Y + w.Y
            };
        }

        // poniżej jest operator zwracający nową instancję, będącą wektorem wymnożonym przez skalar [1-2]
        static public Wektor operator *(Wektor v, double s)
        {
            return new Wektor()
            {
                X = v.X * s,
                Y = v.Y * s
            };
        }
        // poniżej jest operator zwracający nową instancję, będącą wektorem wymnożonym przez skalar [2-2]
        static public Wektor operator *(double s, Wektor v)
        {
            return v * s;
        }

        // poniżej jest operator zwracający nową instację, będącą odwróconą wartością
        static public Wektor operator -(Wektor wektor)
        {
            return wektor * (-1);
        }

        // poniżej jest operator zwracający nową instancję, będącą różnicą wektorów
        static public Wektor operator -(Wektor v, Wektor w)
        {
            return v + -w;
        }

        // poniżej jest operator zwracający nową instancję, będącą wektorem podzielonym przez skalar [1-2]
        static public Wektor operator /(Wektor v, double s)
        {
            return new Wektor()
            {
                X = v.X / s,
                Y = v.Y / s
            };
        }
        // poniżej jest operator zwracający nową instancję, będącą wektorem podzielonym przez skalar [2-2]
        static public Wektor operator /(double s, Wektor v)
        {
            return v / s;
        }

        public override string ToString()
        {
            return $"({X};{Y})";
        }
    }
}
