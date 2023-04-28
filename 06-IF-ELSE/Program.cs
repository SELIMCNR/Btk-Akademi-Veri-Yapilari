using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_IF_ELSE
{
  /*
 Koşul ifadeleri 
eğer 
doğruysa şunu yao 
yanlışsa bunu yap 
gibi 
if() {
}
else {
}

--TekmiÇiftmi 

--Mutlak değer

--k karaktermi 
 */

//K karaktermi

internal class Program
{
    private static void Main(string[] args)
    {
        var k = (char)Console.Read(); //Dışardan gelen değeri tutar.
        if (char.IsDigit(k))
        {
            Console.WriteLine("Rakamdır!");
        }
        else if (char.IsLower(k))
        {
            Console.WriteLine("Kucuk karakter.");
        }
        else if (char.IsUpper(k))
        {
            Console.WriteLine("Buyuk karakter.");
        }
        else
        {
            Console.WriteLine("Bilinmeyen karakter.");
        }



        mutlakDeğer();

        tekCift();

        Console.ReadKey();

          #region Tekciftornegi
        static void tekCift()
        {

            //Tekmi çiftmi 
            Console.WriteLine("Bir sayi giriniz ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0)
            {
                Console.WriteLine($"{sayi} sayısı çifttir ");
            }
            else
            {
                Console.WriteLine($"{sayi} sayısı tektir ");
            }
        }
        #endregion
        static void mutlakDeğer()
        {
            //Mutlak değer

            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine($"|{n}| = {n * -1}");
            }
            else
            {
                Console.WriteLine($"|{n}| = {n}");
            }
        }
    }
}


}
