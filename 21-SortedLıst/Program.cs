using System;
using System.Collections;

namespace _21_SortedLıst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortedList = temeller kolleksiyonlardan
            //Yöntem1
            /*
            var list = new SortedList();
            list.Add(1, "bir");
            list.Add(2,"iki") ;
            */
            //Yöntem2 tanımlama
            var list = new SortedList()
            {{1,"bir"},
                {2,"iki" },
                {3,"Üç" },
                {8 ,"Sekiz"},
                     {6 ,"altı"},
                          {5 ,"beş"}
            };
            list.Add(4, "Dört");
            list.Remove(3); //silme işlemi
            //Dolaşma
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine("Listedeki eleman sayısı :{0} ",list.Count);
            Console.WriteLine("Listenin kapasitesi :{0} ",list.Capacity);
            list.TrimToSize();//kapasiteyi set eder. Listedeki eleman sayısı ile böler.
            Console.WriteLine("Listenin kapasitesi :{0} ",list.Capacity);

            //Erişme
            //Key
            Console.WriteLine(list[4]);
            //ındex
            Console.WriteLine(list.GetByIndex(0));
            //Get key metodu
            Console.WriteLine(list.GetKey(0));
            //Liste sonundaki elemanın değeri
            Console.WriteLine(list.GetByIndex(list.Count-1));
            //Anahtarlar dolaşımı
            var anahtarlar = list.Keys;
            Console.WriteLine("\n Anahtarlar");
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }
            //Değerler dolaşımı
            var degerler = list.Values;
            Console.WriteLine("\n Değerler");
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }
            if (list.ContainsKey(1)) //containskey o değer anahtar var mı 
            {
                list[1] = "One";
            }
            //Dolaşma 
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key}-{item.Value}");
            }
            Console.ReadKey();
        }
    }
}
