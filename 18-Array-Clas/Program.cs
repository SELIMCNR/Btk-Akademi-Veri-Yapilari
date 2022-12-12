using System;
using System.Collections;

namespace _18_Array_Clas
{
    internal class Program
    {
        static void Main(string[] args)
        {// Array | Dizi 
            int[] sayilar = new int[] { 5, 3, 8, 10, 2,18,23,44,55,6,314,19 };
            //Array clasından dizi tanımlama
            var numbers = Array.CreateInstance(typeof(int), sayilar.Length); // Array classından dizi oluşturuyoruz

            //2 tanımlama Array list
            var arr = new ArrayList(sayilar);

            /*Array class kopyalama metodu ile diziye atama*/
            sayilar.CopyTo(numbers,0); /* 0 dan başla numbersa kadar kopyala*/
            
            
            /*
            //Array clasından diziye atama
            numbers.SetValue(-5, 0);
            numbers.SetValue(3, 1);
            numbers.SetValue(8, 2);
            numbers.SetValue(10, 3);
            numbers.SetValue(-2, 4);
            */

            //Array clasından dizide dolaşma
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"sayilar[{i}] = " +
                    $"{sayilar[i],3} - " +
                    $"numbers[{i}] = " +
                    $"{numbers.GetValue(i),3} " +
                    $"arr[{i}] = " +
                    $"{arr[i],3}");
            }
            //Array classında dizi metotları
            Array.Sort(sayilar);
            Array.Sort(numbers);
            Array.Clear(sayilar,2,2); // silme metodu
            var x = Array.IndexOf(sayilar, 44); //ara 44. sayı nerede

            //ArrayList Metodları arrayclassında dizi metod değil
            arr.Sort(); // Sıralama metodu


            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
