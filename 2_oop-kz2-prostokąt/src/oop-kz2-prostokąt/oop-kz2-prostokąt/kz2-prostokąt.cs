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
        public static Dictionary<char, double> wysokośćArkusza0 = new Dictionary<char, double>
        {
            ['A'] = 1189,
            ['B'] = 1414,
            ['C'] = 1297
        };

        // poniżej są rozmiary papieru zgodne z normą ISO 216:
        // => format zasadniczy - szereg A
        // => formaty pomocnicze - szereg B & szereg C
     

        //string[] wymiaryA = {"26×37", "37×52", "52×74", "74×105", "105×148", "148×210", "210×297", "297×420", "420×594", "594×841", "841×1189"};
        string[] wymiaryA = { "841×1189", "594×841", "420×594", "297×420", "210×297", "148×210", "105×148", "74×105", "52×74", "37×52", "26×37" };
        
        // string[] wymiaryB = {"31×44", "44×62", "62×88", "88×125", "125×176", "176×250", "250×353", "353×500", "500×707", "1000×1414", "1000×1414"};
        string[] wymiaryB = { "1000×1414", "1000×1414", "500×707", "353×500", "250×353", "176×250", "125×176", "88×125", "62×88", "44×62", "31×44" };
        
        
        string[] wymiaryC = { "917×1297", "648×917", "458×648", "324×458", "229×324", "162×229", "114×162", "81×114", "57×81", "40×57", "28×40" };

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

        /*public double BokA
        {
            get; set;
        }
        public double BokB
        {
            get; set;
        }*/

        public double pole { get; }
        public double obwod { get; }

        // poniżej jest konstruktor przyjmujący dwa argumenty typu double < 1 >
        public kz2_prostokąt(
            double bok_A,
            double bok_B)
        {
            this.BokA = bok_A;
            this.BokB = bok_B;

            pole = bokA * bokB;
            obwod = 2 * bokA + 2 * bokB;

            Console.WriteLine("pole: " + pole + " obdwod: " + obwod);

            double BOK_A = (Convert.ToDouble(wysokośćArkusza0.ContainsValue('A'))) / Math.Pow(pierwiastekZDwóch, bok_A);
            double BOK_B = BOK_A / pierwiastekZDwóch;

            /*bok_A = (Convert.ToDouble(wysokośćArkusza0.ContainsValue('A'))) / Math.Pow(pierwiastekZDwóch, BokA);
            bok_B = bok_A / pierwiastekZDwóch;*/

            Console.WriteLine($"Wymiary naszego prostokąta to {0} oraz {1}", BOK_A, BOK_B);
        }
        // poniżej jest metoda Prostokąt, która przyjmuje jeden argument typu string < 5 >
        public kz2_prostokąt(string Arkusz_Papieru_format)
        {
            //int p_indeks = Arkusz_Papieru_format.IndexOf(' ');
            int i_p = int.Parse(Arkusz_Papieru_format.Substring(1, 1));
            string a_p = Arkusz_Papieru_format.Substring(0, 1);

            Console.WriteLine("Format naszego arkusza " + a_p + i_p + " ma następujące wymiary " + wymiaryA[i_p] + " [mm]");

            /*double BOK_A =(Convert.ToDouble(wysokośćArkusza0.ContainsValue('A'))) / Math.Pow(pierwiastekZDwóch, i_p);
            double BOK_B = BOK_A / pierwiastekZDwóch;

            Console.WriteLine("Po wykonaniu dodatkowych obliczeń, została obliczona" +
                "\nwysokość i szerokość arkusza " + a_p + " w milimetrach, a więc:" +
                "\n=> bok A wynosi: " + BOK_A +
                "\n=> bok B wynosi: " + BOK_B);*/
        }
    }
}
