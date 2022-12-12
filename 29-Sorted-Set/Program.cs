using System;
using System.Collections.Generic;

namespace _29_Sorted_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SortedSet Küme işlemleri 
            var A = new SortedSet<int> (RastgeleSayiUret(100)); 
            var B = new SortedSet<int> (RastgeleSayiUret(100));
            #region yazdırma
            foreach (int s in A)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();
            
            Console.WriteLine();

            Console.WriteLine("B kümesi");
            foreach (int s in B)
            {
                Console.WriteLine($"{s,5}");
            }
            #endregion

            // union birleşim
            // A.UnionWith(B);  // birleşimi verir
            // A.IntersectWith(B); //kesişimi verir
            // A.ExceptWith(B); // Sade a da olan yani A fark b
            A.SymmetricExceptWith(B);

            Console.WriteLine();
            Console.WriteLine("\n\n ");
            foreach (int s in A)
            {
                Console.WriteLine($"{s,5} kesişim dışında elemanlar");
            }
            Console.WriteLine("Toplam sayisi: {0}",A.Count);
            Console.WriteLine();
            Console.ReadKey();
            SortedSet2sample();
            sortedSetTemel();

        }
        static List <int> RastgeleSayiUret(int n)
        {
            var list = new List<int>();
            var r = new Random();
            for (int i =0; i < n; i++)
            {
                list.Add(r.Next(0,1000));
                
            }
            return list;

        }
        private static void SortedSet2sample()
        {
            //SortedSet
            var sayilar = new List<int>();
            var r = new Random(); /*Random sayılar döndürür*/

            Console.WriteLine();
            for (int i = 0; i < 100; i++)
            {
                sayilar.Add(r.Next(0, 10)); // 0 ile 10 arasında değerler ekler 
                Console.WriteLine($"{sayilar[i],-3}");
            }
            Console.WriteLine();


            // listedeki benzersiz sayıları bulmak
            var benzersizSayiListesi = new SortedSet<int>(sayilar);

            Console.WriteLine();
            Console.WriteLine("\nBenzersiz sayilarin Listesi");

            foreach (int sayi in benzersizSayiListesi)
            {
                Console.WriteLine($"{sayi,-3}");
            }
            Console.WriteLine("Benzersiz {0} sayi var.", benzersizSayiListesi.Count);

         
        }

        private static void sortedSetTemel()
        {
            // System collections generic sınıfı altında yer alır
            // boxing unboxing yok , generic ifade oldundan
            // Elemanları benzersiz olmalıdır. farklı olmalı
            /* Sıralı sıralama ekleme sırasında yer alır. 
             * Add()-> ekleme true-false şeklinde döner.
             * Remove()->silme 
             * Remove Where(producate) koşul 
             * kesişim birleşme, ayrışım,Alt küme durumu sorgulanabilir. 
            */

            //SortedSet 
            //Tanımlama
            var list = new SortedSet<string>();

            //ekleme 
            if (list.Add("Mehmet"))
            {
                Console.WriteLine("Mehmet eklendi.");
            }
            else
            {
                Console.WriteLine("Ekleme başarısız");
            }
            //ekleme 3lü koşul ifadesi
            Console.WriteLine("{0}", list.Add("Ahmet") == true ? "Ahmet eklendi" : "Ekleme başarısız");

            list.Add("Şule");
            list.Add("Neslihan");
            list.Add("Fahrettin");
            list.Add("Fatih");
            Console.WriteLine("\nİsimler Listesi \n");

            //Remove silme 
            list.Remove("Sule");
            list.RemoveWhere(deger => deger.Contains("A")); /* a ile başlayanı sil */
            list.RemoveWhere(deger => deger.StartsWith("f")); /* f ile başlayanları sil*/
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Listedeki eleman sayısı : {0,5}", list.Count);
        }
    }
}
