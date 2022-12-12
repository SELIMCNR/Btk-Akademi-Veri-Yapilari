using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_IF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var k =(char)Console.Read();   //Console.Read() ' en gelen değer integer bir değer olduğu için (cast),(char) işlemi yaptık.
            
            if (char.IsDigit(k))  // ısDıgıt rakam mı 
            {
                Console.WriteLine("Rakamdır!");
            }
            else if (char.IsLower(k)) //Kucukmu
            {
                Console.WriteLine("Kucuk karakter.");
            }
            else if (char.IsUpper(k)) // yuksekmı
            {
                Console.WriteLine("Buyuk karakter.");
            }
            else
            {
                Console.WriteLine("Bilinmeyen Karakter.");
            }
            mutlakDeger();
            tekMiÇiftMi();
            Console.ReadKey();
        }

        private static void mutlakDeger()
        {

            // Mutlak değer
            int n = Convert.ToInt32(Console.ReadLine());  // Convert.ToInt32(Console.ReadLine()) Stringten inte çevriliyor
            if (n < 0)
            {
                Console.WriteLine($"|{n}| = {n * -1}");
            }
            else
            {
                Console.WriteLine($"|{n}| = {n}");
            }
        }

        private static void tekMiÇiftMi()
        {
            // tek // çift 

            int sayi = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32(Console.ReadLine()) Stringten ınte çevirim yapıyor.

            if (sayi % 2 == 0)
            {
                Console.WriteLine($"{sayi} çift bir sayıdır.");
            }
            else
            {
                Console.WriteLine($"{sayi} tek bir sayıdır.");
            }
        }
    }
}
