using System;
using System.Collections.Generic;

namespace _17_Class_Yapısı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Class
            //Tanımlama - Atama
            var List1 = new List<OgretimElamani>() //classdan yeni  liste oluşturduk
            {
                new OgretimElamani(100, "Selim", "Çınar", true),
                new OgretimElamani(101, "Yusuf", "Çınar", true),
                new OgretimElamani(102,"İbrahim","Çınar",false),
                new OgretimElamani(103,"Ali","Çınar",true),
                new OgretimElamani(104,"Fatih","Çınar",false)
            };

            /*
            //Yöntem1 Yazdırma 
            Console.WriteLine("Liste 1");
            foreach (var ogrGor in List1)
            {
                Console.WriteLine(ogrGor);
            }*/

            //Yöntem2 Yazdırma
            Console.WriteLine("Liste 1");
            List1.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();
            List<OgretimElamani> Liste2 = List1; // Liste2 ye liste 1 atandı
            Console.WriteLine("Liste2");
            Liste2.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();
            Liste2.Add(new OgretimElamani(106, "Selim", "Çınar", true));
            Console.WriteLine("lİSTE 2 -> eKLEME YAPILDI . ");
            //Heap ikiside aynı adresden eleaman aldığı için bir listeden eklenen diğerinede ekleniyor
            Console.WriteLine("Liste 1");
            List1.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();
            Console.WriteLine("Liste2");
            Liste2.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();
            List1.RemoveAt(0); //Silinme yapıyor.
            Console.WriteLine("Liste1 den eleman silindi");
            Console.WriteLine(List1);
            Console.WriteLine("Liste 1");
            List1.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();
            Console.WriteLine("Liste2");
            Liste2.ForEach(ogr => Console.WriteLine(ogr));
            Console.ReadKey();
            Class1();
        }

        private static void Class1()
        {

            //Atama3
            OgretimElamani ogrGor = new OgretimElamani(100, "Selim", "Çınar", true);

            Console.WriteLine(ogrGor);
            /*
            //Atama2
            OgretimElamani ogrGor = new OgretimElamani()
            {
                SicilNo = 102,
                Adi = "Yusuf",
                Soyadi="Çınar",
                Cinsiyet = true
            }; //Yeni obje*/
            Console.WriteLine(ogrGor);

            /*
            //Atama1
            ogrGor.SicilNo = 101;
            ogrGor.Adi = "Selim";
            ogrGor.Soyadi = "Çınar";
            ogrGor.Cinsiyet = true;
            */
        }
    }
}
