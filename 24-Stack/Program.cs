using System;
using System.Collections;
using System.Collections.Generic;

namespace _24_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack ile sayının basamaklara ayrılması
            Console.WriteLine("Lütfen bir sayı giriniz :");
            int sayi = Convert.ToInt32(Console.ReadLine());

            var sayiYigini = new Stack<int>();
            while (sayi > 0)
            {
                int k = sayi % 10;
                sayiYigini.Push(k);
                sayi = sayi / 10;
            }

            int i = 0;
            int n = sayiYigini.Count - 1;
            foreach (int s in sayiYigini)
            {
                Console.WriteLine($"{s,6} * {Math.Pow(10,n-i),7} = {s*Math.Pow(10,n-i),8}" );
                i++;
            }

           karakterYığınSeti();
            GenericStackÖrnek();
            Console.ReadKey();
        }

        private static void karakterYığınSeti()
        {
            var karakterYigini = new Stack<char>();
            for (int i = 65; i <= 90; i++)
            {
                karakterYigini.Push((char)(i));
                Console.WriteLine($"{karakterYigini.Peek()} yığına eklendi.");
                Console.WriteLine($"Yığındaki eleman sayisi : {karakterYigini.Count}");
            }
            //Ek bilgi 
            var dizi = karakterYigini.ToArray(); // stack diziye çevrildi.
            Console.WriteLine("Yığından çıkartma işlemi için bir tuşa basın");
            while (karakterYigini.Count > 0)
            {
                Console.WriteLine($"{karakterYigini.Pop()} yığından çıkarıldı.");
                Console.WriteLine($"Yığındaki eleman sayisi : {karakterYigini.Count}");
            }
        }

        private static void GenericStackÖrnek()
        {
            // Stack yığın yapısı
            //Last-in  , First out , son gelen ilk çıkar. Farklı push,pop,peek,clear,count,ToArray lerle çalışır. 

            //Stack Tanımlama
            var karakterYigini = new Stack<char>(); // system-collection-genericten stack oluşumu 

            //Ekleme
            karakterYigini.Push('A');
            Console.WriteLine(karakterYigini.Peek()); /* hangi ifadelerin eklendini gösterir*/
            karakterYigini.Push('B');
            Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('C');
            Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('D');

            //Çıkarma 
            Console.WriteLine(karakterYigini.Pop() + "yığından çıkarıldı.");
            Console.WriteLine(karakterYigini.Pop() + "yığından çıkarıldı.");
            Console.WriteLine(karakterYigini.Pop() + "yığından çıkarıldı.");

        }
    }
}
