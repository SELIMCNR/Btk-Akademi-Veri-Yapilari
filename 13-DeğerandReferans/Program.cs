using System;

namespace _13_DeğerandReferans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10; 
            int y = 20;
            Console.WriteLine("{0},{1}",x,y);
            Degistir(ref x, ref y); // referans tipli oldu  
            Console.WriteLine("{0},{1}", x, y); // burada x,y 'nin referans türünde parametreleri yazıldı
            Console.ReadKey();

        }

        private static void Degistir(ref int a, ref int b) //ref anahtar sözcüğü değerleri referans tipinde parametrelerini döndürür
        {
            int gecici = a;
            a = b; 
            b = gecici;
            Console.WriteLine("{0},{1}", a, b);
        }
    }
}
