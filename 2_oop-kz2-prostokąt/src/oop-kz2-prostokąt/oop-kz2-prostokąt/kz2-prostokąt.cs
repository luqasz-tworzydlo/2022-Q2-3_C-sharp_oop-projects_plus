using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_kz2_prostokąt
{
    class kz2_prostokąt
    {
        // poniżej są niepubliczne pola double bokA i bokB < 2 >
        public double
            bokA,
            bokB;

        static double
            pierwiastekZDwóch = Math.Sqrt(2);

        // poniżej jest słownik Dictionary, który ma za zadanie zwrócić daną wartość < 4 >
        /*readonly static Dictionary<char, double> wysokośćArkusza0 = new Dictionary<char, double>()
        {
            ['A'] = 1189,
            ['B'] = 1414,
            ['C'] = 1297
        };*/

        // poniżej są rozmiary papieru zgodne
        // z normą ISO 216 dla szeregu A i B,
        // i ISO 269 dla szeregu C, gdzie:
        // => format zasadniczy - szereg A
        // => formaty pomocnicze - szereg B & szereg C
        string[] wymiaryA = { "841×1189", "594×841", "420×594", "297×420", "210×297", "148×210", "105×148", "74×105", "52×74", "37×52", "26×37" };
        string[] wymiaryB = { "1000×1414", "1000×1414", "500×707", "353×500", "250×353", "176×250", "125×176", "88×125", "62×88", "44×62", "31×44" };
        string[] wymiaryC = { "917×1297", "648×917", "458×648", "324×458", "229×324", "162×229", "114×162", "81×114", "57×81", "40×57", "28×40" };
        // zrobić jeden słownik [!!!]
        // słownik krotek [ string, ... 
        // Dictionary<string,(double,double)>

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
        public kz2_prostokąt(
            double bok_A,
            double bok_B)
        {
            this.BokA = bok_A;
            this.BokB = bok_B;

            Pole_Arkusza = BokA * BokB;
            Obwód_Arkusza = 2 * BokA + 2 * BokB;
            Przekątna_Arkusza = Math.Sqrt(BokA * BokA + BokB + BokB);

            Console.WriteLine("\nWymiary naszego arkusza to: " + BokA + " i " + BokB + ", gdzie:");
            Console.WriteLine("=> pole naszego arkusza wynosi: " + Pole_Arkusza +
                "\n=> obwód naszego  arkusza wynosi: " + Obwód_Arkusza +
                "\n=> przekątna naszego arkusza wynosi: " + Przekątna_Arkusza);

            double BOK_A = BokA / Math.Pow(pierwiastekZDwóch, 0);
            double BOK_B = BOK_A / pierwiastekZDwóch;

            /*bok_A = (Convert.ToDouble(wysokośćArkusza0.ContainsValue('A'))) / Math.Pow(pierwiastekZDwóch, BokA);
            bok_B = bok_A / pierwiastekZDwóch;*/

            Console.WriteLine("Wymiary naszego arkusza [prostokąta] po wypróbowaniu [wykonaniu]" +
                "\ndanych, określonych operacji matematycznych to: " + BOK_A + " x " + BOK_B);
        }
        // poniżej jest metoda Prostokąt, która przyjmuje jeden argument typu string < 5 >
        public kz2_prostokąt(string Arkusz_Papieru_format)
        {
            //int p_indeks = Arkusz_Papieru_format.IndexOf(' ');
            int i_p = int.Parse(Arkusz_Papieru_format.Substring(1, 1));
            string a_p = Arkusz_Papieru_format.Substring(0, 1);

            // dodanie warunku poprzez switch, który sprawdza rodzaj arkuszu papieru [czy to jest A, B, czy C]
            string F_P;
            F_P = Convert.ToString(a_p);
            switch (F_P)
            {
                case "A": Console.WriteLine("\nFormat arkusza " + a_p + i_p + " ma następujące wymiary: " + wymiaryA[i_p] + " [mm]"); break;
                case "B": Console.WriteLine("\nFormat arkusza " + a_p + i_p + " ma następujące wymiary: " + wymiaryB[i_p] + " [mm]"); break;
                case "C": Console.WriteLine("\nFormat arkusza " + a_p + i_p + " ma następujące wymiary: " + wymiaryC[i_p] + " [mm]"); break;
                default:
                    Console.WriteLine("Nie wprowadzono danych! :<"); break;
            }
        }
    }
}
