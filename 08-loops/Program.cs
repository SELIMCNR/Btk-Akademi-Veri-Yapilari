using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            forLoops();
            //doWhıle();
            // whıleLoops2();
            //whıleLoops();
            Console.ReadKey();
        }

        private static void forLoops()
        {
            //For loops
            /*
                   //Sample One
                   for (int i = 0; i <=1907; i+=5)
                   {
                       Console.WriteLine("Fenerbahçe {0}",i);
                   }


                   //Sample two
                   for (int i = 100; i >= 0; i -= 5)
                   {
                       Console.WriteLine("Fenerbahçe {0,7}", i);
                   }

                   int a = Convert.ToInt32(Console.ReadLine());
                   int b = Convert.ToInt32(Console.ReadLine());    

                   //Sample three kare alma işlemi
                   for (int i = a; i <= b; i++)
                   {
                       Console.Write("{0,3} {1,3} ",i,i*i);
                   }

                   //Sample Four 
                   for (int i = a; i <=b; i++)
                   {
                       if (i == 100)
                           // continue; devam ettir
                           break;
                       Console.WriteLine("{0,3}",i);
                   }
            */
            //Sample five
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    // Console.WriteLine(" {0},{1}",i+1,j+1);
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }

        private static void doWhıle()
        {
            //Klavyeden okunan çift sayılar 

            Console.WriteLine("Bir sayı giriniz");
            int n = Convert.ToInt32(Console.ReadLine());//dışardan girilen veriyi tutar

            int i = 2;
            do   // koşula bakmadan bir kere yazdırır.
            {
                Console.Write("{0,3}", i);
                i = i + 2; // i +=2 

            } while (i <= n);
        }

        private static void whıleLoops2()
        {
            int sayac = 10;
            while (sayac > 0)
            {
                //Console.Write(" "+sayac+" ");//Yan yana yazılması için Console.Write();
                //Console.Write("{0,-3}",sayac);//0 ifade gelecek 5 karakter boşluklu
                Console.WriteLine("{0,-3} {1,-3}", sayac, sayac * sayac);
                // sayac = sayac + 1;//sayac++; sayac +=1;
                sayac = sayac - 1; // sayac-=1
            }
        }

        private static void whıleLoops()
        {

            //While 
            int i = 0; // koşul tanımlanması
            int sayac = 0;  //sayac tanımlanması
            while (i < 10)  //döngü başlangıç
            {
                sayac++; //sayac artırım
                Console.WriteLine(sayac); //sayac yazdırma
                i++; //döngü artırma
            }

            Console.WriteLine("Döngü sonu.");
        }
    }
}
