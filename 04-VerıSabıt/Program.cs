using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_VerıSabıt
{
    //Char karakterleri tutar  
/*
 -ASCII  : American Standart Code for Information 
    Interchange
 - 7-bit  2 li sayı sistemi  -0 , -1 olarak tutar bilgisayar kodları . 128 karakter var ASCII DE ORNEK: 0-9 rakamlar   a-z  , A-Z  .,_?{}() GİBİ .
    her bit 0-1 olarak tutulur bellekte.
    8bit  1byte , 1024 byte 1kb , 1024kb 1mb , 1024mb 1 gb , 1024gb 1 tb
 
 */

internal class Program
{
    private static void Main(string[] args)
    {
        var ifade = "Merhaba programlama dünyası.";
        Console.WriteLine(ifade);
        Console.WriteLine(ifade.Length); //Karakter uzunluğu alır
        Console.WriteLine(ifade.ToUpper()); //Büyük harfle yazar
        Console.WriteLine(ifade.ToLower()); //Küçük harfle yazar
        Console.WriteLine(ifade.TrimStart()); //Baştaki boşlukları sil
        Console.WriteLine(ifade.TrimEnd()); //Sondaki boşlukları sil
        Console.WriteLine(ifade.Trim()); //Hem baş hem sondaki karakterleri sil 
        Console.WriteLine(ifade[0]);
        Console.WriteLine(ifade[1]);
        Console.WriteLine(ifade[2]);
        Console.WriteLine(ifade[ifade.Length - 1]);

        ortuluDegisken();
        Console.ReadKey();
        static void ortuluDegisken()
        {

            //Console.ReadLine() dışardan değer alır. 
            string ifade = Console.ReadLine();

            //Örtülü değişken var : Çalışma zamnında runtime da değerine karar verilir. 
            var ifade2 = Console.ReadLine();

            //Read key karaktere tıklama anı
            var ifade3 = Console.ReadKey();
            Console.WriteLine(ifade3.Key);
            Console.WriteLine(ifade3.KeyChar);

            Console.WriteLine(ifade);
        }
    }
}
}
