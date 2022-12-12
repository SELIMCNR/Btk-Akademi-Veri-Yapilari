using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double[,,]3boyutlu 2 virgül var ,double[,,,]4boyutlu
            double[,] matris = new double[,] { { 1, 2, 3,3 }, { 2, 3, 4 ,5}, { 3, 4, 5 ,6}, };

            double toplam = 0;

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        matris[i, j] = -1;
                    }
                    if (matris[i,j] % 2 ==0)
                    {
                        matris[i, j] = 0;
                    }
                    toplam += matris[i, j];
                    Console.Write($"{matris[i,j],5}");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Toplam : {toplam}");
           diziSample();

            arrays();
            Console.ReadKey();
        }

        private static void diziSample()
        {
            Console.WriteLine("Dizi boyutunu giriniz. ");
            int boyut = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[boyut]; //Boyutunu dışardan alan dizi 
            var r = new Random(); //Random değerler objesi

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = r.Next(1, 10); //Rastgele 1 ile 10 arası atama

            }
            foreach (int s in sayilar) // foreach koleksiyonları döndürmede kullanılır.
            {
                Console.WriteLine($"{s,5} {s * s,5}"); //sayilar dizisinde rastgele sayılar döndürülüyor
            }
        }

        private static void arrays()
        {

            //Arrays -Diziler
            //Diziler 0.indeksten başlar,sabit boyutludur
            int[] numaralar;//dizi tanımı 

            // başlatma
            numaralar = new int[3]; //3 indisli atama yapılacak
            numaralar[0] = 3; //0.indese atama yapıldı
            numaralar[1] = 5;
            numaralar[2] = 7;

            //2.yöntem dizi tanımlama & başlatma
            int[] numaralar1 = new int[3];

            //3.yöntem dizi tanımlama & başlatma & atama
            int[] numaralar3 = new int[] { 3, 5, 7, 8, 10 };

            //4.yöntem dizi tanımlama & başlatma & atama
            int[] numaralar4 = { 3, 5, 7, 8, 10 };

            for (int i = 0; i < numaralar.Length; i++)
            {
                Console.WriteLine($"numaralar[{i}] = {numaralar[i]} ");
            }
        }
    }
}
