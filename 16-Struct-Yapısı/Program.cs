using System;
using System.Collections.Generic;


namespace _16_Struct_Yapısı
{
        public struct Nokta
        {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"{X},{Y}";
        }
        //defaul constractor
        public Nokta(int x, int y)
        {
            X = x;
            Y = y;
        }
        //Yapıya yeni üye metot
        public void SetOrigin()
        {
            X = 0;
            Y = 0;
        }
        public void Degistir()
        {
            var gecici = X;
            X = Y;
            Y = gecici;
        }


       internal class Program
        {
            public static void Main(string[] args)
            {
           

             
                //Struct2
                Struct2();

                Console.ReadKey();
                // Struct1
                StructYapısı();

            }

            private static void Struct2()
            {
                //Struct 2 Değer tipli 
                var n1 = new Nokta(3, 4);
                Console.WriteLine($"N1 : {n1}");
                n1.Degistir();
                Console.WriteLine($"N1 : {n1}");
                var n2 = n1;
                Console.WriteLine($"N2 : {n2}");
                n2.X = -1 * n2.X;
                Console.WriteLine($"n1: {n1}");
                Console.WriteLine($"n2: {n2}");
            }

            private static void StructYapısı()
            {
                //Struct  bir veya daha fazla gerek kullanıcı gerek yerleşik bunların birleşimidir
                // Struct değer tipli , Class referans tipli çalışır
                //Struct - Kullanma
                Ogrenci ogr = new Ogrenci();  // yeni obje ekledik
                ogr.Numara = 10; // property'e eriştik
                ogr.Adi = "Selim";
                ogr.Soyadi = "Çınar";
                ogr.Cinsiyet = true;

                // Alternatif kullanma 
                var ogr2 = new Ogrenci()
                {
                    Numara = 630,
                    Adi = "Selim",
                    Soyadi = "Çınar",
                    Cinsiyet = false,
                };

                // Alternatif kullanma 2



                var ogrenciListesi = new List<Ogrenci>()
            {
                new Ogrenci(10,"Ahmet","Yılmaz"),
                new Ogrenci(20,"Fatma","Dag",false),
                new Ogrenci(30, "Mehmet", "Avşar", true),
               new Ogrenci(40, "Asaf", "Karlıdağ"), // varsayılan değer geldi.
        
            };
                /*1.yöntem*/
                foreach (Ogrenci o in ogrenciListesi)
                {
                    Console.WriteLine(o);
                }
                //2.yöntem lamda
                ogrenciListesi.ForEach(o => Console.WriteLine(o));
            }
        }
    }
}
