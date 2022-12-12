using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Verı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 2 * x;
            Console.WriteLine(y.GetType()); // veri tipini gösteriyor
            Console.WriteLine(y);
            Console.ReadKey();

            var x1 = "1";
            var  x2 = "2";
            var toplam=x1 + x2;
            Console.WriteLine(toplam.GetType());
            Console.WriteLine(toplam);
            Console.ReadKey();;

        }
    }
}
