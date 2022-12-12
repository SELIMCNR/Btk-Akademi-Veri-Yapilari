using System;
using System.Collections.Generic;

namespace _14_LıstApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sehirler = new List<string>()
            {
                "Ankara",
                "İstanbul",
                "Van",
                "Samsun",
                "Ordu"
            };
            foreach(string s in sehirler)
            {
                Console.WriteLine(s);
            }

            //Lamda expression = > Listelerde daha kolay dolaşım sağlar
            sehirler.ForEach(s => Console.WriteLine(s)); // lamda dolaşımı
            Console.WriteLine("-",50);

            var iller = sehirler; // örtülü değişkenle atama
            iller.ForEach(i => Console.WriteLine(i));

            sehirler.Add("Kahramanmaraş");
            sehirler.ForEach(s => Console.WriteLine(s));
            Console.WriteLine();
            iller.ForEach(i => Console.WriteLine(i));

            iller.Remove("Ankara");
            iller.ForEach(i => Console.WriteLine(i));
            Console.WriteLine();
            sehirler.ForEach(s => Console.WriteLine(s));
    
            Console.ReadKey();
        }
    }
}
