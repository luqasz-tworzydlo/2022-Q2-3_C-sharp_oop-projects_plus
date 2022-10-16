﻿using System;
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

        // wartości dziesiętne
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

        // 'prasowanie' i zmiana na wartości szesnastkowe
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

        // konstruktor [wyświetlenie naszych wartości]
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

        // hex   bin   color
        // 0    0000    black
        // -- -- -- -- -- -- -- -- --
        // 3    0011    cyan
        // -- -- -- -- -- -- -- -- --
        // 5    0101    magneta
        // 6    0110    brown
        // -- -- -- -- -- -- -- -- --
        // 8    1000    dark gray

        // wartości dziesiętne
        byte
            black = 00, // decimal value [ 00 ] => hex value [ 00 ] => binary value [ 0000 0000 ]
            cyan = 51, // decimal value [ 51 ] => hex value [ 33 ] => binary value [ 0011 0011 ]
            magneta = 85, // decimal value [ 85 ] => hex value [ 55 ] => binary value [ 0101 0101 ]
            brown = 102, // decimal value [ 102 ] => hex value [ 66 ] => binary value [ 0110 0110 ]
            dark_gray = 136; // decimal value [ 136 ] => hex value [ 88 ] => binary value [ 1000 1000 ]
        
        public byte Black
        {
            get { return black; }
            set { if (value == 0) throw new Exception(); else black = value; }
        }
        public byte Cyan
        {
            get { return cyan; }
            set { if (value == 0) throw new Exception(); else cyan = value; }
        }
        public byte Magneta
        {
            get { return magneta; }
            set { if (value == 0) throw new Exception(); else magneta = value; }
        }
        public byte Brown
        {
            get { return brown; }
            set { if (value == 0) throw new Exception(); else brown = value; }
        }
        public byte Dark_Gray
        {
            get { return dark_gray; }
            set { if (value == 0) throw new Exception(); else dark_gray = value; }
        }

        // 'prasowanie' i zmiana na wartości szesnastkowe
        string black_b, cyan_c, magneta_m, brown_b, dark_gray_dg;

        public string Black_b_Parase
        {
            get
            {
                string decimalValueR = "00"; int numberR = int.Parse(decimalValueR);
                black_b = numberR.ToString("x"); return black_b;
            }
        }
        public string Cyan_c_Parase
        {
            get
            {
                string decimalValueR = "51"; int numberR = int.Parse(decimalValueR);
                cyan_c = numberR.ToString("x"); return cyan_c;
            }
        }
        public string Magneta_m_Parase
        {
            get
            {
                string decimalValueR = "85"; int numberR = int.Parse(decimalValueR);
                magneta_m = numberR.ToString("x"); return magneta_m;
            }
        }
        public string Brown_b_Parase
        {
            get
            {
                string decimalValueR = "102"; int numberR = int.Parse(decimalValueR);
                brown_b = numberR.ToString("x"); return brown_b;
            }
        }
        public string Dark_gray_dg_Parase
        {
            get
            {
                string decimalValueR = "136"; int numberR = int.Parse(decimalValueR);
                dark_gray_dg = numberR.ToString("x"); return dark_gray_dg;
            }
        }

        // < test > konwertowanie z systemu dwójkowego [binarnego] na dziesiętny
        /*public string Test_Convert_From_Bin_To_Dec
        {
            get
            {
                string test = Convert.ToInt32("00110011", 2).ToString();
                return test;
            }
        }*/

        // < test > konwertowanie z systemu dziesiętnego na dwójkowy [binarny]
        /*public string Test_Convert_From_Dec_To_Bin
        {
            get
            {
                int decimal_value = 51;
                string binary_value = Convert.ToString(decimal_value, 2);
                return binary_value;
            }
        }*/

        // konwertowanie z systemu dziesiętnego na dwójkowy [binarny]
        public string BlackBinary_Convert_From_Dec_To_Bin
        {
            get
            {
                string binary_value = Convert.ToString(black, 2);
                return binary_value;
            }
        }
        public string CyanBinary_Convert_From_Dec_To_Bin
        {
            get
            {
                string binary_value = Convert.ToString(cyan, 2);
                return binary_value;
            }
        }
        public string MagnetaBinary_Convert_From_Dec_To_Bin
        {
            get
            {
                string binary_value = Convert.ToString(magneta, 2);
                return binary_value;
            }
        }
        public string BrownBinary_Convert_From_Dec_To_Bin
        {
            get
            {
                string binary_value = Convert.ToString(brown, 2);
                return binary_value;
            }
        }
        public string DarkGrayBinary_Convert_From_Dec_To_Bin
        {
            get
            {
                string binary_value = Convert.ToString(dark_gray, 2);
                return binary_value;
            }
        }

        public override (byte R, byte G, byte B) RGB
        {
            get => base.RGB;
            set => base.RGB = value;
        }


        // konstruktor nr 1 [wyświetlenie naszych wartości]
        /*public Barwa12()
        {
            Console.WriteLine(
                "\n/// /// /// /// /// /// /// /// /// /// /// /// \n");

            Console.WriteLine(
                $"Colors - Decimal Values:" +
                $"\n=> black: {Black}" +
                $"\n=> cyan: {Cyan}" +
                $"\n=> magneta: {Magneta}" +
                $"\n=> brown: {Brown}" +
                $"\n=> dark_gray: {Dark_Gray}");

            Console.WriteLine(
                $"\nColors - Hexadecimal Values:" +
                $"\n=> black: {Black_b_Parase}" +
                $"\n=> cyan: {Cyan_c_Parase}" +
                $"\n=> magneta: {Magneta_m_Parase}" +
                $"\n=> brown: {Brown_b_Parase}" +
                $"\n=> dark_gray: {Dark_gray_dg_Parase}");

            Console.WriteLine(
                $"\nColors - Binary Values:" +
                $"\n=> black: {BlackBinary_Convert_From_Dec_To_Bin}" +
                $"\n=> cyan: {CyanBinary_Convert_From_Dec_To_Bin}" +
                $"\n=> magneta: {MagnetaBinary_Convert_From_Dec_To_Bin}" +
                $"\n=> brown: {BrownBinary_Convert_From_Dec_To_Bin}" +
                $"\n=> dark_gray: {DarkGrayBinary_Convert_From_Dec_To_Bin}");

            *//*Console.WriteLine(
                $"\n=> Binary Value to Decimal Value < test >: {Test_Convert_From_Bin_To_Dec}" +
                $"\n=> Decimal Value to Binary Value < test >: {Test_Convert_From_Dec_To_Bin}");*//*
        }*/

        // konstruktor nr 2 [wyświetlenie naszych wartości]
        public override string ToString()
        {
            return $"\n/// /// /// /// /// /// /// /// /// /// /// ///\n" +
                $"\n" +
                $"Colors - Decimal Values:" +
                $"\n=> black: {Black}" +
                $"\n=> cyan: {Cyan}" +
                $"\n=> magneta: {Magneta}" +
                $"\n=> brown: {Brown}" +
                $"\n=> dark_gray: {Dark_Gray}" +
                $"\n" +
                $"\nColors - Hexadecimal Values:" +
                $"\n=> black: {Black_b_Parase}" +
                $"\n=> cyan: {Cyan_c_Parase}" +
                $"\n=> magneta: {Magneta_m_Parase}" +
                $"\n=> brown: {Brown_b_Parase}" +
                $"\n=> dark_gray: {Dark_gray_dg_Parase}" +
                $"\n" +
                $"\nColors - Binary Values:" +
                $"\n=> black: {BlackBinary_Convert_From_Dec_To_Bin}" +
                $"\n=> cyan: {CyanBinary_Convert_From_Dec_To_Bin}" +
                $"\n=> magneta: {MagnetaBinary_Convert_From_Dec_To_Bin}" +
                $"\n=> brown: {BrownBinary_Convert_From_Dec_To_Bin}" +
                $"\n=> dark_gray: {DarkGrayBinary_Convert_From_Dec_To_Bin}"
                ;
        }
    }
    internal class BarwaPółprzezroczysta : Barwa
    {
        // hex   bin   color
        // -- -- -- -- -- -- -- -- --
        // 7    0111    light gray
        // -- -- -- -- -- -- -- -- --
        // 9    1001    light blue
        // a    1010    light green
        // b    1011    light cyan
        // c    1100    light red
        // d    1101    light magneta
        // e    1110    yellow
        // f    1111    white

        byte
            light_gray = 68, // decimal value [ 68 ] => hex value [ 44 ]
            light_blue = 34, // decimal value [ 34 ] => hex value [ 22 ]
            light_green = 17,
            light_cyan = 17,
            light_red = 17,
            light_magneta = 17,
            yellow = 17,
            white = 17;


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