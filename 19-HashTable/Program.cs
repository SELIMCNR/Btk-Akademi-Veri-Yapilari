using System;
using System.Collections;

namespace _19_HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HashTable altındaki soyut sınıfların metodlarına uymak zorund
            //Tanımlama
            var sehirler = new Hashtable(); //Hashtable objesi oluşturuldu

            //Ekleme
            sehirler.Add(46,"Kahramanmaraş");
            sehirler.Add(6, "Ankara");
            sehirler.Add(34, "İstanbul");
            sehirler.Add(55, "Samsun");
            sehirler.Add(23, "Elazığ");

            //Dolaşma DictionaryEntry üzerinde gel f12 ye bas 
            foreach (DictionaryEntry item in sehirler) //DictionaryEntry tipinden key,value ile veri çektik
            {
                Console.WriteLine($"{item.Key,-5}" +
                    $"- {item.Value,-20}");
            }

            Console.WriteLine("Anahtarlar (keys,)");
            //Anahtarları alma Key alma
            var anahtarlar = sehirler.Keys;
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }

            //Değerler Values 
            ICollection degerler = sehirler.Values; // Ikolleksiyon tipi oluşturuldu
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }

            // Özel Elemana erişim
            Console.WriteLine("Elemana erişme: ");
            Console.WriteLine(sehirler[46]);

            // Eleman silme
            Console.WriteLine("\n Elemana erişme : ");
            sehirler.Remove(34);


            //Dolaşma DictionaryEntry üzerinde gel f12 ye bas 
            foreach (DictionaryEntry item in sehirler) //DictionaryEntry tipinden key,value ile veri çektik
            {
                Console.WriteLine($"{item.Key,-5}" +
                    $"- {item.Value,-20}");
            }


            Console.ReadKey();
        }
    }
}
