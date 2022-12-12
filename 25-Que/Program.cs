using System;
using System.Collections.Generic;

namespace _25_Que
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sesliHarfler = new List<char>()
            {
                'a','e','ı','i','u','ü','o','ö'
            };

            ConsoleKeyInfo secim;
            var kuyruk = new Queue<char>();

            foreach (char k in sesliHarfler)
            {
                Console.WriteLine();
                Console.WriteLine($"{k,-5} kuyruğa eklensin mi? [e/h]");
                Console.ReadKey();
                secim = Console.ReadKey();
                Console.WriteLine();
                if(secim.Key == ConsoleKey.E)
                {
                    kuyruk.Enqueue(k);
                    Console.WriteLine($"\n{k,-5} kuyruğa eklendi.");
                    Console.WriteLine($"Kuyruktaki eleman sayısı: {kuyruk.Count}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Kuyruktan elemanlarin kaldırılması işlemi için Esc tuşuna basınız.");
            secim = Console.ReadKey();
   
           if(secim.Key == ConsoleKey.Escape)
            {
                Console.WriteLine();
                while (kuyruk.Count > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{kuyruk.Peek(),5} kuyruktan çıkartılıyor.");
                    Console.WriteLine($"{kuyruk.Dequeue(),5} kuyruktan çıkarıldı.");
                    Console.WriteLine($"Kuyruktaki eleman sayisi: {kuyruk.Count}");
                }
                Console.WriteLine("\n Kuyruktan çıkarma işlemi tamamlandı.");

            }

            Console.WriteLine("Program bitti ");
            
            quetemelleri();
            Console.ReadKey();

        }

        private static void quetemelleri()
        {
            // Que Kuyruj system collec generic boxing unboxing yok 
            // t-> type->
            //First-in First-Out(Fifo). ilk gelen ilk çıkar
            //enqueue,dequeue,peek,count,clear

            //Sesli Harfler yazan program
            var karakterKuyruğu = new Queue<char>();//sys-collec-generic 
            //ekleme
            karakterKuyruğu.Enqueue('a');
            karakterKuyruğu.Enqueue('b');
            karakterKuyruğu.Enqueue('e');
            Console.WriteLine($"Eleman sayısı: {karakterKuyruğu.Count}");

            var dizi = karakterKuyruğu.ToArray(); // que diziye ekleme

            //Çıkarma
            Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyruğu.Peek()}");
            Console.WriteLine($"{karakterKuyruğu.Dequeue()} kuyruktan çıkartıldı.");
            Console.WriteLine($"Eleman sayisi: {karakterKuyruğu.Count}");
            Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyruğu.Peek()}");
        }
    }
}
