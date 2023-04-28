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


        // See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Değişkenler 
/*
 Yerleşik tip : int , double-float,datetime,bool,char,string....

 Kullanıcı tarafli tipler : struct,class 

-isimlendirme : rakamla değişken başlamaz, # ? ! bunlar değişkende kullanılmaz ama _ kullanılır , 
  anahtar kelimeler değişken isimlendirmesinde kullanılamaz.for,while,if,using,enum vs.
 -UpperCase  -> UzunFonksiyonAdi;
 -camelCase  -> uzunFonksiyonAdi;
 Türkçe karakter  ç,ğ,ı,i,u,ü dikkat edilmeli.

 */

//Karakter dizeleri 
/* yorum satırı */
// refactoring hızlı eylemler yapılır 
// escape \n  alt satıra geç, \t boşluk bırak, \a alarm ver  kaçış ifadeleri 

string ifade = "\n Btk \n Akademi \n Programlama \n Ogreniyorum.";
string ifade1 = "\t Btk \t Akademi \t Programlama \t Ogreniyorum.";

string ifade2 = "\a Btk \a Akademi \a Programlama \a Ogreniyorum.";

//Dosya yolu yazımları 
string ifade3 = "C:\\user\\zcomert";
string ifade4 = @"C:\user\zcomert";

Console.WriteLine(ifade);



sayiOrnek();

degiskenOrnek();
Console.ReadKey();
}
static void degiskenOrnek()
{
    //tip 
    int sayi1;
    double s2 = 0.15;
    float pi = 3.14f;
    char secim = 'e';
    string isim = "selim";
    bool dogruMu = false;

    //değer atama
    isim = "Yusuf";
    string soyad = "Çınar";

    Console.WriteLine("Merhaba " + isim + " " + soyad + ".");
    isim = "İbrahim";
    Console.WriteLine("Merhaba Sayın " + isim + ".");
}

static void sayiOrnek()
{
    int sayi = 5;
    Console.WriteLine(sayi);
    Console.WriteLine(sayi + 2);
    Console.WriteLine(sayi * sayi);
    Console.WriteLine(sayi - 5);
}   
    }
}
