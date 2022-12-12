

internal class Program
{
    private static void Main(string[] args)
    {
        // Overloading aşırı yükleme yapma
        var odenecekMiktar = SatisYap(100);
        Console.WriteLine(odenecekMiktar);

        var odenecekMiktar2 = SatisYap(100, .1);
        Console.WriteLine(odenecekMiktar2);






        /// <summary>
        /// Satiş yapan fonksiyon
        /// </summary>
         static double SatisYap(double miktar=0)
        {
            return miktar * 1.18;
        }
        /// <summary>
        /// Satiş yapan fonksiyon
        /// </summary>
        static double SatisYap(double miktar, double indirim)
        {
            return miktar * (1.0 - indirim) * 1.18;
        }

        MetotTasarimi();
        Console.ReadKey();


        // Metod Tanımı
        static void Karsilastir()
        {
            Console.WriteLine("Karsilastir metodu calisti.");
            Console.WriteLine(" . ");
            Console.WriteLine(" . ");
        }
        //Metod 2. yöntem
        static int sayiKarsilastir(int A, int B)
        {
            if (A > B)
            {
                return A;
            }
            else
            {
                return B;
            }
        }


        //Metod 3. yöntem
        static int sayiKarsilastirma(int A, int B)
        {
            return A > B ? A : B;
        }

        // Method Ornek 
        static double KareAl(double sayi)
        {
            double kare = sayi * sayi;
            return kare;
        }


        double SeriToplami(params double[] seri)
        {
            double toplam = 0;
            foreach (double s in seri)
            {
                toplam += s;
            }
            return toplam;
        } //Dışardan double veri alan dizi

        void MetotTasarimi()
        {
            Karsilastir(); // metod çağrıldı
            int buyuk = sayiKarsilastir(3, 8); //2.metod çağrıldı
            Console.WriteLine(buyuk);
            sayiKarsilastirma(4, 15); // 3.metod çağrıldı

            var x = KareAl(3);
            double y = KareAl(x);
            double toplam = SeriToplami(5.52, 15.12, 25.54, 13.13); // Params ile oluşturulan metod
            Console.WriteLine("{0,5:0.##}", toplam);

            Console.WriteLine(x); // Kareal metodu değişken içerisinde çağrıldı.
            Console.WriteLine(y); // kareal metodu farklı bir değişkende çağrıldı.

            Console.WriteLine("Metot bitti.");

        }
    }
}
