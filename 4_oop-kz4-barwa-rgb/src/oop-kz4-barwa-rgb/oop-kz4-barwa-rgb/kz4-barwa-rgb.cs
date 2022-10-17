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

        public virtual (byte Black, byte Cyan, byte MagnetaB, byte Brown, byte Dark_Gray) Colors12 { get; set; }

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
    internal class BarwaPółprzezroczysta : Barwa12
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

        // wartości dziesiętne
        byte
            light_gray = 119, // decimal value [ 119 ] => hex value [ 77 ] => binary value [ 0111 0111 ]
            light_blue = 153, // decimal value [ 153 ] => hex value [ 99 ] => binary value [ 01001 1001 ]
            light_green = 170, // decimal value [ 170 ] => hex value [ AA ] => binary value [ 01010 1010 ]
            light_cyan = 187, // decimal value [ 187 ] => hex value [ BB ] => binary value [ 1011 1011 ]
            light_red = 204, // decimal value [ 204 ] => hex value [ CC ] => binary value [ 1100 1100 ]
            light_magneta = 221, // decimal value [ 221 ] => hex value [ DD ] => binary value [ 1101 1101 ]
            yellow = 238, // decimal value [ 238 ] => hex value [ EE ] => binary value [ 1110 1110 ]
            white = 255; // decimal value [ 255 ] => hex value [ FF ] => binary value [ 1111 1111 ]

        public byte Light_Gray
        {
            get { return light_gray; }
            set { if (value == 0) throw new Exception(); else light_gray = value; }
        }
        public byte Light_Blue
        {
            get { return light_blue; }
            set { if (value == 0) throw new Exception(); else light_blue = value; }
        }
        public byte Light_Green
        {
            get { return light_green; }
            set { if (value == 0) throw new Exception(); else light_green = value; }
        }
        public byte Light_Cyan
        {
            get { return light_cyan; }
            set { if (value == 0) throw new Exception(); else light_cyan = value; }
        }
        public byte Light_Red
        {
            get { return light_red; }
            set { if (value == 0) throw new Exception(); else light_red = value; }
        }
        public byte Light_Magneta
        {
            get { return light_magneta; }
            set { if (value == 0) throw new Exception(); else light_magneta = value; }
        }
        public byte Yellow
        {
            get { return yellow; }
            set { if (value == 0) throw new Exception(); else yellow = value; }
        }
        public byte White
        {
            get { return white; }
            set { if (value == 0) throw new Exception(); else white = value; }
        }

        // 'prasowanie' i zmiana na wartości szesnastkowe
        string light_gray_lg, light_blue_lb, light_green_lg, light_cyan_lc, light_red_lr, light_magneta_lm, yellow_y, white_w;

        public string Light_gray_lg_Parase
        {
            get
            {
                string decimalValueR = "119"; int numberR = int.Parse(decimalValueR);
                light_gray_lg = numberR.ToString("x"); return light_gray_lg;
            }
        }
        public string Light_blue_lb_Parase
        {
            get
            {
                string decimalValueR = "153"; int numberR = int.Parse(decimalValueR);
                light_blue_lb = numberR.ToString("x"); return light_blue_lb;
            }
        }
        public string Light_green_lg_Parase
        {
            get
            {
                string decimalValueR = "170"; int numberR = int.Parse(decimalValueR);
                light_green_lg = numberR.ToString("x"); return light_green_lg;
            }
        }
        public string Light_cyan_lc_Parase
        {
            get
            {
                string decimalValueR = "187"; int numberR = int.Parse(decimalValueR);
                light_cyan_lc = numberR.ToString("x"); return light_cyan_lc;
            }
        }
        public string Light_red_lr_Parase
        {
            get
            {
                string decimalValueR = "204"; int numberR = int.Parse(decimalValueR);
                light_red_lr = numberR.ToString("x"); return light_red_lr;
            }
        }
        public string Light_magneta_lm_Parase
        {
            get
            {
                string decimalValueR = "221"; int numberR = int.Parse(decimalValueR);
                light_magneta_lm = numberR.ToString("x"); return light_magneta_lm;
            }
        }
        public string Yellow_y_Parase
        {
            get
            {
                string decimalValueR = "238"; int numberR = int.Parse(decimalValueR);
                yellow_y = numberR.ToString("x"); return yellow_y;
            }
        }
        public string Alfa_Parase
        {
            get
            {
                string decimalValueR = "255"; int numberR = int.Parse(decimalValueR);
                white_w = numberR.ToString("x"); return white_w;
            }
        }

        // konwertowanie z systemu dziesiętnego na dwójkowy [binarny]
        public string LightGray_Convert_From_Dec_To_Bin
        {
            get
            {
                string binary_value = Convert.ToString(light_gray, 2);
                return binary_value;
            }
        }
        public string LightBlue_Convert_From_Dec_To_Bin
        {
            get
            {
                string binary_value = Convert.ToString(light_blue, 2);
                return binary_value;
            }
        }
        public string LightGreen_Convert_From_Dec_To_Bin
        {
            get
            {
                string binary_value = Convert.ToString(light_green, 2);
                return binary_value;
            }
        }
        public string LightCyan_Convert_From_Dec_To_Bin
        {
            get
            {
                string binary_value = Convert.ToString(light_cyan, 2);
                return binary_value;
            }
        }
        public string LightRed_Convert_From_Dec_To_Bin
        {
            get
            {
                string binary_value = Convert.ToString(light_red, 2);
                return binary_value;
            }
        }
        public string LightMagneta_Convert_From_Dec_To_Bin
        {
            get
            {
                string binary_value = Convert.ToString(light_magneta, 2);
                return binary_value;
            }
        }
        public string Yellow_Convert_From_Dec_To_Bin
        {
            get
            {
                string binary_value = Convert.ToString(yellow, 2);
                return binary_value;
            }
        }
        public string Alfa_Convert_From_Dec_To_Bin
        {
            get
            {
                string binary_value = Convert.ToString(white, 2);
                return binary_value;
            }
        }

        public byte Alfa { get => white; set => white = value; }

        public override (byte Black, byte Cyan, byte MagnetaB, byte Brown, byte Dark_Gray) Colors12
        {
            get => base.Colors12;
            set => base.Colors12 = value;
        }

        public virtual (byte R, byte G, byte B, byte Alfa) RGBA { get; set; }

        public string RrGgBbAa
        {
            get
            {
                return $"({Rr_Parase},{Gg_Parase},{Bb_Parase}, {Alfa_Parase})";
            }
        }
        public string RrrGggBbbAaa
        {
            get
            {
                return
                    $"\nRGBA Decimal Values:" +
                    $"\n=> red: {R}" +
                    $"\n=> green: {G}" +
                    $"\n=> blue: {B}" +
                    $"\n=> alfa: {Alfa}" +
                    $"\n" +

                    $"\nRGBA Hexadecimal Values:" +
                    $"\n=> red: {Rr_Parase}" +
                    $"\n=> green: {Gg_Parase}" +
                    $"\n=> blue: {Bb_Parase}" +
                    $"\n=> alfa: {Alfa_Parase}" +
                    $"\n" +

                    $"\n\"#RrGgBbAa\" {RrGgBbAa}"
                    ;
            }
        }

        // konstruktor [niekompletny]
        /*public override string ToString()
        {
            return $"\n/// /// /// /// /// /// /// /// /// /// /// ///\n" +
                $"\n" +
                $"ColorsPlus - Decimal Values:" +
                $"\n=> light_gray: {Light_Gray}" +
                $"\n=> light_blue: {Light_Blue}" +
                $"\n=> light_green: {Light_Green}" +
                $"\n=> light_cyan: {Light_Cyan}" +
                $"\n=> light_red: {Light_Red}" +
                $"\n=> light_magneta: {Light_Magneta}" +
                $"\n=> yellow: {Yellow}" +
                $"\n=> white: {White}" +
                $"\n" +
                $"\nColorsPlus - Hexadecimal Values:" +
                $"\n=> light_gray: {Light_gray_lg_Parase}" +
                $"\n=> light_blue: {Light_blue_lb_Parase}" +
                $"\n=> light_green: {Light_green_lg_Parase}" +
                $"\n=> light_cyan: {Light_cyan_lc_Parase}" +
                $"\n=> light_red: {Light_red_lr_Parase}" +
                $"\n=> light_magneta: {Light_magneta_lm_Parase}" +
                $"\n=> yellow: {Yellow_y_Parase}" +
                $"\n=> white: {White_w_Parase}" +
                $"\n" +
                $"\nColorsPlus - Binary Values:" +
                $"\n=> light_gray: {LightGray_Convert_From_Dec_To_Bin}" +
                $"\n=> light_blue: {LightBlue_Convert_From_Dec_To_Bin}" +
                $"\n=> light_green: {LightGreen_Convert_From_Dec_To_Bin}" +
                $"\n=> light_cyan: {LightCyan_Convert_From_Dec_To_Bin}" +
                $"\n=> light_red: {LightRed_Convert_From_Dec_To_Bin}" +
                $"\n=> light_magneta: {LightMagneta_Convert_From_Dec_To_Bin}" +
                $"\n=> yellow: {Yellow_Convert_From_Dec_To_Bin}" +
                $"\n=> white: {White_Convert_From_Dec_To_Bin}"
                ;
        }*/

        // konstruktor [uzupełniony] (z naszymi danymi)
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
                $"\n=> dark_gray: {DarkGrayBinary_Convert_From_Dec_To_Bin}" +
                $"\n" +

                $"\n/// /// /// /// /// /// /// /// /// /// /// ///\n" +
                $"\n" +
                $"ColorsPlus - Decimal Values:" +
                $"\n=> light_gray: {Light_Gray}" +
                $"\n=> light_blue: {Light_Blue}" +
                $"\n=> light_green: {Light_Green}" +
                $"\n=> light_cyan: {Light_Cyan}" +
                $"\n=> light_red: {Light_Red}" +
                $"\n=> light_magneta: {Light_Magneta}" +
                $"\n=> yellow: {Yellow}" +
                $"\n=> white: {White}" +
                $"\n" +
                $"\nColorsPlus - Hexadecimal Values:" +
                $"\n=> light_gray: {Light_gray_lg_Parase}" +
                $"\n=> light_blue: {Light_blue_lb_Parase}" +
                $"\n=> light_green: {Light_green_lg_Parase}" +
                $"\n=> light_cyan: {Light_cyan_lc_Parase}" +
                $"\n=> light_red: {Light_red_lr_Parase}" +
                $"\n=> light_magneta: {Light_magneta_lm_Parase}" +
                $"\n=> yellow: {Yellow_y_Parase}" +
                $"\n=> white: {Alfa_Parase}" +
                $"\n" +
                $"\nColorsPlus - Binary Values:" +
                $"\n=> light_gray: {LightGray_Convert_From_Dec_To_Bin}" +
                $"\n=> light_blue: {LightBlue_Convert_From_Dec_To_Bin}" +
                $"\n=> light_green: {LightGreen_Convert_From_Dec_To_Bin}" +
                $"\n=> light_cyan: {LightCyan_Convert_From_Dec_To_Bin}" +
                $"\n=> light_red: {LightRed_Convert_From_Dec_To_Bin}" +
                $"\n=> light_magneta: {LightMagneta_Convert_From_Dec_To_Bin}" +
                $"\n=> yellow: {Yellow_Convert_From_Dec_To_Bin}" +
                $"\n=> white: {Alfa_Convert_From_Dec_To_Bin}"

                ;
        }

        /*public byte A
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
        }*/

    }
}