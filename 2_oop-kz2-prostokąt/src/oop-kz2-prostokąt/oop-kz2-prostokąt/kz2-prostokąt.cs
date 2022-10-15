using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_kz2_prostokąt
{
    class Prostokąt
    {
        // poniżej są niepubliczne pola double bokA i bokB < 2 >
        public double
            bokA,
            bokB;

        // poniżej są rozmiary papieru zgodne
        // z normą ISO 216 dla szeregu A i B,
        // i ISO 269 dla szeregu C, gdzie:
        // => format zasadniczy - szereg A
        // => formaty pomocnicze - szereg B & szereg C
        /// string[] wymiaryA = { "841×1189", "594×841", "420×594", "297×420", "210×297", "148×210", "105×148", "74×105", "52×74", "37×52", "26×37" };
        /// string[] wymiaryB = { "1000×1414", "1000×1414", "500×707", "353×500", "250×353", "176×250", "125×176", "88×125", "62×88", "44×62", "31×44" };
        /// string[] wymiaryC = { "917×1297", "648×917", "458×648", "324×458", "229×324", "162×229", "114×162", "81×114", "57×81", "40×57", "28×40" };
        // sposób nr 1 - powyższy sposób wywoływania poszczególnych formatów został zastąpiony
        // jeden słownikiem krotek, czyli Dictionary<string,(double,double)>

        // sposób nr 2 - użycie słownika [ rozmiary papieru -https://pl.wikipedia.org/wiki/Format_arkusza#Norma_ISO_216 ]
        Dictionary<string, (double, double)> wymiary = new Dictionary<string, (double, double)>()
        {
            ["4A0"] = (1682, 2378),
            ["2A0"] = (1189, 1682),
            ["A0"] = (841, 1189),
            ["A1"] = (594, 841),
            ["A2"] = (420, 594),
            ["A3"] = (297, 420),
            ["A4"] = (210, 297),
            ["A5"] = (148, 210),
            ["A6"] = (105, 148),
            ["A7"] = (74, 105),
            ["A8"] = (52, 74),
            ["A9"] = (37, 52),
            ["A10"] = (26, 37),


            ["B0"] = (1000, 1414),
            ["B1"] = (707, 1000),
            ["B2"] = (500, 707),
            ["B3"] = (353, 500),
            ["B4"] = (250, 353),
            ["B5"] = (176, 250),
            ["B6"] = (125, 176),
            ["B7"] = (88, 125),
            ["B8"] = (62, 88),
            ["B9"] = (44, 62),
            ["B10"] = (31, 44),

            ["C0"] = (917, 1297),
            ["C1"] = (648, 917),
            ["C2"] = (458, 648),
            ["C3"] = (324, 458),
            ["C4"] = (229, 324),
            ["C5"] = (162, 229),
            ["C6"] = (114, 162),
            ["C7"] = (81, 114),
            ["C8"] = (57, 81),
            ["C9"] = (40, 57),
            ["C10"] = (28, 40),
            };

        // poniżej są publiczne właściwości double BokA i BokB < 3 >
        public double BokA
        {
            get { return bokA; }
            set
            {
                bokA = value;
                if (bokA > 0)
                    bokA = value;
                else
                    throw new Exception("Błąd! Wprowadzono wartość ujemną dla boku A");
            }
        }
        public double BokB
        {
            get { return bokB; }
            set
            {
                bokB = value;
                if (bokB > 0)
                    bokB = value;
                else
                    throw new Exception("Błąd! Wprowadzono wartość ujemną dla boku B");
            }
        }

        public double Pole_Arkusza { get; }
        public double Obwód_Arkusza { get; }
        public double Przekątna_Arkusza { get; }

        // poniżej jest konstruktor przyjmujący dwa argumenty typu double < 1 >
        public Prostokąt(
            double bok_A,
            double bok_B)
        {
            this.BokA = bok_A;
            this.BokB = bok_B;

            Pole_Arkusza = BokA * BokB;
            Obwód_Arkusza = 2 * BokA + 2 * BokB;
            Przekątna_Arkusza = Math.Sqrt(BokA * BokA + BokB + BokB);

            Console.WriteLine("\nWymiary naszego prostokąta to: " + BokA + " i " + BokB + ", gdzie:");
            Console.WriteLine("=> pole naszego prostokąta wynosi: " + Pole_Arkusza +
                "\n=> obwód naszego prostokąta wynosi: " + Obwód_Arkusza +
                "\n=> przekątna naszego prostokąta wynosi: " + Przekątna_Arkusza);
        }
        // poniżej jest metoda Prostokąt, która przyjmuje jeden argument typu string < 5 >
        public Prostokąt(string Arkusz_Papieru_format)
        {
            // poniższy sposób nr 2 [ z użyciem słownika ]

            string w_p = Arkusz_Papieru_format;
            Console.WriteLine("\nFormat arkusza " + w_p + " ma następujące wymiary: " + wymiary[w_p] + " [mm]");

            // /// /// /// /// /// /// /// /// /// /// /// ///

            // ponizszy sposób nr 1 [ wyłączony z użytku ]

            //int p_indeks = Arkusz_Papieru_format.IndexOf(' ');
            /*int i_p = int.Parse(Arkusz_Papieru_format.Substring(1, 1));
            string a_p = Arkusz_Papieru_format.Substring(0, 1);*/

            // dodanie warunku poprzez switch, który sprawdza rodzaj arkuszu papieru [czy to jest A, B, czy C]
            // poniższy sposób był wcześniej używany do wypisywania konkrentych wartości arkuszy [obecenie zastąpiony słownikiem]
            /*string F_P;
            F_P = Convert.ToString(a_p);
            switch (F_P)
            {
                case "A": Console.WriteLine("\nFormat arkusza " + a_p + i_p + " ma następujące wymiary: " + wymiaryA[i_p] + " [mm]"); break;
                case "B": Console.WriteLine("\nFormat arkusza " + a_p + i_p + " ma następujące wymiary: " + wymiaryB[i_p] + " [mm]"); break;
                case "C": Console.WriteLine("\nFormat arkusza " + a_p + i_p + " ma następujące wymiary: " + wymiaryC[i_p] + " [mm]"); break;
                default:
                    Console.WriteLine("Nie wprowadzono danych! :<"); break;
            }*/
        }
    }
}
