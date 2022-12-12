using System;
using System.Collections;

namespace _22_SortedListUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortedList
            var kitapIcerigi = new SortedList();
            kitapIcerigi.Add(1, "Önsöz");
            kitapIcerigi.Add(50, "Değişkenler");
            kitapIcerigi.Add(40, "Operatörler");
            kitapIcerigi.Add(60, "Döngüler");
            kitapIcerigi.Add(45, "İlişkisel Operatörler");
            
            Console.WriteLine("İçindekiler");
            Console.WriteLine(new String ('-',25));

            Console.WriteLine($"{"Konular",-30} {"Sayfalar",5}");
            foreach (DictionaryEntry item in kitapIcerigi)
            {
                Console.WriteLine($"{item.Value,-30} {item.Key,5}");
            }
            Console.ReadKey();
        }
    }
}
