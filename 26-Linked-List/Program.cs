using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace _26_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System collections.Generic sınıfına aittir 
            //boxin unboxing yok generic yapıda-> biz bildiriyoruz.
            //Doğrusal veri yapısıdır.İlk düğüm first son düğüm last , first.next bir sonraki düğüm
            //Last.previous ile sondan bir önceki düğüm gibi çalışır.s
            //add first ile ilk elemana ekleme , add last son eleman ekleme
            //Add before, Add after Next/preveous value özellikleri de var.

            //LinkedList<T> Temelleri 
            //Tanımlama
            var sehirler = new LinkedList<string>();
            sehirler.AddFirst("Kahramanmaraş"); // 0 ındis kahramanmaraş
            sehirler.AddFirst("Trabzon");  // 1 indis Tranbzon
            sehirler.AddLast("İstanbul"); // en son indise İstanbul at
            
            sehirler.AddAfter(sehirler.Find("Kahramanmaraş"),"Samsun"); // Kahramanmaraşı bul ondan sonra Samsun ekle
            sehirler.AddBefore(sehirler.First.Next.Next, "Giresun"); // ordudan sonra yani 3.indis
            sehirler.AddAfter(sehirler.Last.Previous, "Sinop"); // Samsundan sonra yani 4.indis
            sehirler.AddAfter(sehirler.Find("Sinop"), "Zonguldak");
            Console.WriteLine();
            Console.WriteLine("Gidiş Güzergahı");
            
            var eleman = sehirler.First; 
            while (eleman!= null)
            {
                Console.WriteLine(eleman.Value);
                eleman = eleman.Next;
            }

            Console.WriteLine();
            Console.WriteLine("Dönüş Güzergahı");
            Console.WriteLine();

            var gecici = sehirler.Last; //listeyi tersten yazdırır
            while (gecici != null)
            {
                Console.WriteLine(gecici.Value);
                gecici = gecici.Previous; //listeyi tersten yazdırır
            }

            Console.ReadKey();

        }
    }
}
