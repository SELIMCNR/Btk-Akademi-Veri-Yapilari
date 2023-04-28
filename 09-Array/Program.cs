using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Array
{
  /*
 Diziler 
 - Temel veri yapısıdır.
 - Sabit boyutludur. 
 
bellek te  indisler halinde tutulur 
[0] , [1],[2]   gibi indisler 0 'dan başlar 


char tipli dizilerde  1 byte yerkaplar her indisde
int tipli dizilerde  4 byte yerkaplar her indisde

--Dizilerin kendine özel metotları vardır 
Rank  , length , IndexOf ,Copy gibi.

 */

// referans tipli ifade new ile başlatılmalı

internal class Program
{
    private static void Main(string[] args)
    {
        // iki boyutlu dizi 
        double[,] matris = new double[,] { { 1, 2, 3 }, { 2, 3, 4 } };
        double toplam = 0;
        for (int i = 0; i < matris.GetLength(0); i++)
        {
            for (int j = 0; j < matris.GetLength(1); j++)
            {
                if (i == j)
                {
                    matris[i, j] = -1;
                }
                if (matris[i, j] % 2 == 0)
                {
                    matris[i, j] = 0;
                }
                toplam += matris[i, j];
                Console.Write($"{matris[i, j],5}");
            }
            Console.WriteLine();
        }

        foreachAndDizi();
        Arrays();

        static void Arrays()
        {

            //Tanımlama 
            int[] numaralar;

            // başlatma 
            numaralar = new int[3]; // 3 indis kutulu bir dizi oluştu

            numaralar[0] = 0;   //ilk indise kutuya 0 değerini at
            numaralar[1] = 5;   //ikinci indise kutuya 5 değerini at
            numaralar[2] = 7;   //ücüncü indise kutuya 7 değerini at

            //Dizilerde dolaşım yap dizi uzunluğunca döngü dönsün
            for (int i = 0; i < numaralar.Length; i++)
            {
                //Dizideki indis kutuların içinde değerleri yazdır.
                Console.WriteLine(numaralar[i]);
            }


            //3.yöntem dizi tanımlama & başlatma & atama
            int[] numaralar3 = new int[] { 3, 5, 7, 8, 10 };

            //4.yöntem dizi tanımlama & başlatma & atama
            int[] numaralar4 = { 3, 5, 7, 8, 10 };


            /* Pratik yöntem tanımlama başlatma atama*/
            int[] numaralar2 = { 3, 5, 7, 8, 10, 11 };
            for (int i = 0; i < numaralar2.Length; i++)
            {
                Console.WriteLine($"Numaralar[{i}] = " + "${ numaralar2[i] }");
            }

        }


        Console.ReadKey();

        static void foreachAndDizi()
        {
            Console.WriteLine("Dizi boyutunu giriniz");
            //Dışardan boyut dizide olacak indis kutu bilgisi alındı
            int boyut = Convert.ToInt32(Console.ReadLine());
            //Random sayı almak
            var r = new Random();
            //Dizi tanımı
            int[] sayilar = new int[boyut];

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = r.Next(1, 10);  // 1 ve 10 arasında rastgele sayı ata
            }

            //Foreach : Koleksiyonlardaki değerleri döndürmek yazdırmak için kullanılır.
            foreach (var s in sayilar)
            {
                Console.WriteLine($"{s,5} {s * s,5}");
            }
        }
    }
}
}
