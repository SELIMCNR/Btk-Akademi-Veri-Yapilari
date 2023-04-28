using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_loops
{
    internal class Program
    {
    /*

Döngüler ve çeşitleri 

--for  for (int i =0; i<10; i++){işlemleri yap}
--while
--do-while
--foreach

 */


internal class Program
{
    private static void Main(string[] args)
    {
        forLoop();

        doWhileOrnek();

        whileOrnek();

        Console.ReadKey();

        static void whileOrnek()
        {
            //While döngü i ken anlamında
            #region while örnek
            int i = 1;
            int sayac = 0;
            while (i < 10)  //doğru olduğu sürece çalış 
            {
                sayac++;
                Console.WriteLine("Döngü bloğu!");
                Console.WriteLine(i);
                i++;   //i değerini artır.
            }
            Console.WriteLine("Döngü sonu");
            Console.ReadKey();
            #endregion
            #region while örnek 2 
            int sayac1 = 1;
            while (i <= 10)
            {
                Console.WriteLine("{0,-3} {1,-3} " + sayac1, sayac1 * sayac1); //5 Karakter boşluklu yaz 
                sayac1 += 1;
                //sayac++;  sayac = sayac + 1;
                //sayac+=1; sayac = sayac + 1;
            }
            #endregion
            #region while örnek 3 
            int sayac2 = 10;
            while (i > 0)
            {
                Console.WriteLine("{0,-3} {1,-3} " + sayac1, sayac2 * sayac2); //5 Karakter boşluklu yaz 
                sayac2 -= 1;
                //sayac--;  sayac = sayac - 1;
                //sayac-=1; sayac = sayac - 1;
            }
            #endregion
        }

        static void doWhileOrnek()
        {
            Console.WriteLine("Bir sayi giriniz : ");

            int n = Convert.ToInt32(Console.ReadLine());
            int i = n;
            do
            {
                Console.Write("{0,3}", i);
                i += 2;  // i = i + 2

            } while (i < n);
        }

        static void forLoop()
        {

            #region içiçedöngü 
            int n1 = 5;
            for (int i11 = 0; i11 < n1; i11++)
            {
                for (int j = 0; j <= n1; j++)
                {
                    Console.WriteLine(" * ");
                }
                Console.WriteLine();
            }


            #endregion

            #region Girilen değerlerin arasını hesapla break
            int ab = Convert.ToInt32(Console.ReadLine());
            int ba = Convert.ToInt32(Console.ReadLine());
            for (int i4 = ab; i4 <= ba; i4++)
            {
                if (i4 == 100)
                {
                    break;  //döngü kır
                }

                Console.Write("{0,3}", i4);
            }
            #endregion

            #region Girilen değerlerin arasını hesapla
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i3 = a; i3 <= b; i3++)
            {
                if (i3 % 3 == 0)
                {
                    continue;  //devam ettir
                }

                Console.Write("{0,3}", i3);
            }
            #endregion


            #region Sayıların karesini gösterme
            for (int i2 = 0; i2 < 10; i2++)
            {
                Console.WriteLine("{0,3} {1,3}", i2, i2 * i2);
            }
            #endregion

            #region 100'den başla 5'er azalt 
            for (int i1 = 100; i1 >= 0; i1 -= 5)
            {
                Console.WriteLine(i1);
            }
            #endregion

            //5'er artış 50 'ye kadar 
            for (int i = 0; i < 50; i += 5)
            {

                Console.WriteLine(i);
            }
        }
    }
}
    }    
}
