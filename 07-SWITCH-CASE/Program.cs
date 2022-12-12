using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_SWITCH_CASE
{
    internal class Program
    {
        enum Islemler   // listeleme işlemleri c # 
        {
            Toplama,
            Cikarma,
            Carpma,
            Bolme
        }

        static void Main(string[] args)
        {
            int A = 10;
            int B = 20;
            // Islemler secim = (Islemler)1; // listeden eleman çağırma statik
            Islemler secim = (Islemler)(new Random().Next(1, 4)); // new nesne oluşturdu random rastgele next 1,4 arası sayı
            switch (secim)
            {
                case Islemler.Toplama:
                    Console.WriteLine($"{A} + {B} = {A + B}");
                    break;
                case Islemler.Cikarma:
                    Console.WriteLine($"{A} - {B} = {A - B}");
                    break;
                case Islemler.Carpma:
                    Console.WriteLine($"{A} * {B} = {A * B}");
                    break;
                case Islemler.Bolme:
                    Console.WriteLine($"{A} / {B} = {A / B}");
                    break;
            }


            Console.ReadKey(); 
        }
    }
}
