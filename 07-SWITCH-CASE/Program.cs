using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_SWITCH_CASE
{
  /*
 
 Koşul 
durum 1 
    Yapılacak işlemler ; break;
durum 2 
    Yapılacak işlemler ; break;
durum 3 
    Yapılacak işlemler ; break;
varsayılan durum 
    Yapılacak işlemler ; break;

 */

internal class Program
{
    enum Islemler
    {
        Toplama=1,
        Cikarma=2,
        Carpma=3,
        Bolme=4
    }
    private static void Main(string[] args)
    {
        int sayi1 = 10;
        int sayi2 = 20;

        //Random enumdan seçim al
        Islemler secim = (Islemler)(new Random().Next(1, 4)); 

        switch (secim)
        {
            case Islemler.Toplama:
                Console.WriteLine($"{sayi1} + {sayi2} = {sayi1 + sayi2}");
                break;
            case Islemler.Cikarma:
                Console.WriteLine($"{sayi1} - {sayi2} = {sayi1 - sayi2}");
                break;
            case Islemler.Carpma:
                Console.WriteLine($"{sayi1} * {sayi2} = {sayi1 * sayi2}");
                break;
            case Islemler.Bolme:
                Console.WriteLine($"{sayi1} / {sayi2} = {sayi1 / sayi2}");
                break;
            default:
                Console.WriteLine("Geçersiz işlem ! ");
                break;
        }

        Console.ReadKey();
    }
}
}
