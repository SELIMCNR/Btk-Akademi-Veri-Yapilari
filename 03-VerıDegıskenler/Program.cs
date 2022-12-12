using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_VerıDegıskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {


            yorumSatırı();
            sayıDegısken();
            degiskenOrnek();
            Console.ReadKey();
        }

        private static void yorumSatırı()
        {
            // Yorum Satırı 
            /*Yorum 
              Blogğu
             */
            // "C:\\user\\zcomert"; kaçış ifadesi
            // @"C:\\user\\zcomert"
            //\n alt satır boşluğu \t yan satır boşluk \a alarm uyarı sesi 
            String ifade = " \n Btk Akademi Programlama Ogreniyorum";
            Console.WriteLine(ifade);
        }

        private static void sayıDegısken()
        {
            int sayi = 5;
            Console.WriteLine(sayi);
            Console.WriteLine(sayi + 2);
            Console.WriteLine(sayi * sayi);
            Console.WriteLine(sayi - 5);
        }

        private static void degiskenOrnek()
        {
            // tip degiskenler
            int sayi1;
            double pi = 3.14;
            char secim = 'e';
            String name = "Selim";
            bool dogruMu = false;


            

            // tip atama 
            string isim;
            isim = "Ahmet";
            string surname = "Çınar";
            Console.WriteLine("Merhaba " + isim + " .");
            Console.WriteLine("Merhaba Sayın " + surname + ".");
           
        }
    }
}
