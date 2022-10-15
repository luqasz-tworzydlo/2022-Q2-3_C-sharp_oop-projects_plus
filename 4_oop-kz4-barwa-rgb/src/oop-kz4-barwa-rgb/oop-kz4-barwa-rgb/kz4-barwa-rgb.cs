using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_kz4_barwa_rgb
{
    internal class Barwa
    {
        // hex   bin   color
        // 0    0000    black
        // 1    0001    blue            => B [ 11 ]
        // 2    0010    green           => G [ 22 ]
        // 3    0011    cyan
        // 4    0100    red             => R [ 44 ]
        // 5    0101    magneta
        // 6    0110    brown
        // 7    0111    light gray
        // 8    1000    dark gray
        // 9    1001    light blue
        // a    1010    light green
        // b    1011    light cyan
        // c    1100    light red
        // d    1101    light magneta
        // e    1110    yellow
        // f    1111    white

        public virtual (byte R, byte G, byte B) RGB { get; set; }

        byte
            r = 68, // decimal value [ 68 ] => hex value [ 44 ]
            g = 34, // decimal value [ 34 ] => hex value [ 22 ]
            b = 17; // decimal value [ 17 ] => hex value [ 11 ]

        public byte R
        {
            get
            {
                return r;
            }
            set
            {
                if (value == 0)
                    throw new Exception();
                else
                    r = value;
            }
        }
        public byte G
        {
            get
            {
                return g;
            }
            set
            {
                if (value == 0)
                    throw new Exception();
                else
                    g = value;
            }
        }
        public byte B
        {
            get
            {
                return b;
            }
            set
            {
                if (value == 0)
                    throw new Exception();
                else
                    b = value;
            }
        }

        string rr, gg, bb;

        public string Rr_Parase
        {
            get
            {
                string decimalValueR = "68";
                int numberR = int.Parse(decimalValueR);
                rr = numberR.ToString("x");
                return rr;
            }
        }
        public string Gg_Parase
        {
            get
            {
                string decimalValueG = "34";
                int numberG = int.Parse(decimalValueG);
                gg = numberG.ToString("x");
                return gg;
            }
        }
        public string Bb_Parase
        {
            get
            {
                string decimalValueB = "17";
                int numberB = int.Parse(decimalValueB);
                bb = numberB.ToString("x");
                return bb;
            }
        }

        public string RrGgBb
        {
            get
            {
                return $"({Rr_Parase},{Gg_Parase},{Bb_Parase})";
            }
        }

        public Barwa()
        {
            Console.WriteLine(
                $"RGB Decimal Values:" +
                $"\n=> red: {R}" +
                $"\n=> green: {G}" +
                $"\n=> blue: {B}");

            Console.WriteLine(
                $"\nRGB Hexadecimal Values:" +
                $"\n=> red: {Rr_Parase}" +
                $"\n=> green: {Gg_Parase}" +
                $"\n=> blue: {Bb_Parase}");

            Console.WriteLine(
                $"\n\"#RrGgBb\" {RrGgBb}"
                );
        }

        /*public override string ToString()
        {
            return $"{R}, {G}, {B} colors";
        }*/
    }
    internal class Barwa12 : Barwa
    {

        public override (byte R, byte G, byte B) RGB
        {
            get => base.RGB;
            set => base.RGB = value;
        }

        public override string ToString()
        {
            return $"{R}, {G}, {B} colors";
        }
    }
    internal class BarwaPółprzezroczysta : Barwa12
    {
        public byte A
        {
            get
            {
                return (byte)((this.Value >> 0x18) & 0xffL); // 0x18 is 24, 0xff is 255
            }
        }
        public new long Value { get; private set; }

        private static long MakeArgb(byte alpha, byte red, byte green, byte blue)
        {
            return (long)(((ulong)((((red << 0x10) | (green << 8))
                | blue) | (alpha << 0x18))) & 0xffffffffL);
        }

    }
}