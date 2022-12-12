using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_VerıSabıt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var ifade1 = "Merhaba programlama dünyası";
            Console.WriteLine(ifade1);        // program direk çalıştı
            Console.WriteLine(ifade1.Length); // program uznluğu
            Console.WriteLine(ifade1.ToUpper()); //programın hepsi büyük
            Console.WriteLine(ifade1.ToLower()); //programın hepsi küçük
            Console.WriteLine(ifade1.TrimStart());// baştan böl
            Console.WriteLine(ifade1.TrimEnd()); // sondan böl 
            Console.WriteLine(ifade1[0]);// 0.karakter
            Console.WriteLine(ifade1[1]);
            Console.WriteLine(ifade1[2]);
            Console.WriteLine(ifade1[ifade1.Length-1]); // sondan bir önceki karakter
            ortuluDegısken();

            dısardanVeri();
            Console.ReadKey();

        }

        private static void ortuluDegısken()
        {
            //Ortulu degisken
            var ifade = Console.ReadKey();
            Console.WriteLine(ifade.Key); // yazılan değerin büyük harfini getirir
            Console.WriteLine(ifade.KeyChar); // yazılan değeri getirir.
        }

        private static void dısardanVeri()
        {
            //Dışardan veri alma string değer döndürür
            var ifade = Console.ReadLine();
            Console.WriteLine(ifade);
        }
    }
}
