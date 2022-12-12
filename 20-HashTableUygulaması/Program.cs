using System;
using System.Collections;

namespace _20_HashTableUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hashtable uygulamasi
            //Başlık okuma
            Console.WriteLine("Başlık giriniz: ");
            string baslik = Console.ReadLine();

            //Kucultme
            baslik = baslik.ToLower();

            // Hashtable
            var karakterSeti = new Hashtable()
            {
                {'ç','c'},
                {'ı','i'},
                {'ö','o'},
                {'ü','u'},
                {' ','-'},
                {'\'','-'},
                {'ğ','g'},
                {'.','-'},
                {'?','-'},
            };
            foreach(DictionaryEntry item in karakterSeti )
            {
                baslik = baslik.Replace((char)item.Key,(char)item.Value); //Replace yerine koyma metodu char değeri istiyor.
            }
            //Ekranda yazdır
            Console.WriteLine(baslik);
            Console.ReadKey();
        }
    }
}
