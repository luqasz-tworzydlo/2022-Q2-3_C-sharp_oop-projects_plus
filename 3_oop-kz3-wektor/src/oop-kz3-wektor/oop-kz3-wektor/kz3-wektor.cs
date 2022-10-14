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
        public byte Wymiar
        {
            get { return (byte)współrzędne.Length; }
        }
        public double Długość
        {
            get
            {
                return Math.Sqrt(
                    IloczynSkalarny(this, this)
                    );
            }
        }
        public Wektor(byte wymiar)
        {
            współrzędne = new double[wymiar];
        }
        public Wektor(params double[] współrzędne)
        {
            this.współrzędne = (double[])współrzędne.Clone();
        }
        public static double IloczynSkalarny(
            Wektor v,
            Wektor w)
        {
            if (v.Wymiar != w.Wymiar)
                return double.NaN;
            double suma = 0;
            for (byte indeks = 0; indeks < v.Wymiar; indeks++)
                suma += v.współrzędne[indeks] * w.współrzędne[indeks];
                // suma += v[indeks] * w[indeks];
            return suma;
        }
        public static Wektor Suma(
            Wektor v,
            Wektor w)
        {
            if (v.Wymiar != w.Wymiar)
                throw new Exception(
                    $"Niezgodne wymiary sumowanych wektorów {v.Wymiar} i {w.Wymiar}");

            Wektor nowy = new Wektor(v.Wymiar);
            for (byte indeks = 0; indeks < v.Wymiar; indeks++)
                nowy.współrzędne[indeks] = v.współrzędne[indeks] + w.współrzędne[indeks];
                // nowy[indeks] = v[indeks] + w[indeks];

            return nowy;
        }
    }
}
