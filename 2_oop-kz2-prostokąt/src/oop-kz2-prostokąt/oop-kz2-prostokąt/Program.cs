using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_kz2_prostokąt
{
    class Program
    {
        static void Main(string[] args)
        {
            kz2_prostokąt P1 = new kz2_prostokąt("A3");
            kz2_prostokąt P2 = new kz2_prostokąt("A2");
            kz2_prostokąt P3 = new kz2_prostokąt(10,5);

            /*Console.WriteLine(P1);
            Console.WriteLine(P2);
            Console.WriteLine(P3);*/

            Console.ReadKey();
        }
    }
}
