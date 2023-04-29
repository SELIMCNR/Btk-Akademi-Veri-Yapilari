

internal class Program
{
    /*
 Metotlar

-Metot / Fonksiyon / Yordam / Altyordam
-Tekrar eden değerlerde kullanılır.
-Erişim belirteci public ,internal ,protectec,private  Dönüş tipi varsa int,double vs  yoksa void olur
Metot adı (parametre listesi )

- Static herhangi bir nesneye ihtiyaç olmadan metodu çalıştırır.

 
 
 */
    private static void Main(string[] args)
    {
        Karsilastir();
        Console.WriteLine("Metot bitti.");

        int buyuk = Karsilastir2(3, 5);
        Console.WriteLine(buyuk);

        int big = Karsilastir3(25, 30);
        Console.WriteLine(big);

        var x = KareAl(3);
        double y = KareAl(x);
        Console.WriteLine(x);
        Console.WriteLine(y);


        //Parametresi sonsuz olan fonksiyon 
        double toplam = SeriToplami(5.5, 15.0, 25.5);
        Console.WriteLine("{0,5:0.## }", toplam);

        var odenecekMiktar = SalesUs(5.5);
        Console.WriteLine(odenecekMiktar);


        var odenecekMiktar2 = SalesUs(100, .2);
        Console.WriteLine("{0,5:0.##}", odenecekMiktar2);


        Console.WriteLine(odenecekMiktar);


        Console.ReadKey();
    }
    /// <summary>
    /// Satış yapan fonksiyon
    /// </summary>
    /// <param name="miktar"></param>
    /// <param name="indirim"> </param>
    /// <returns> </returns>
        static void Karsilastir()
        {
            Console.WriteLine("Karsilastir calisti.");
            Console.WriteLine(".");
            Console.WriteLine(".");
        }
        static int Karsilastir2(int sayi1, int sayi2)
        {
            if (sayi1 > sayi2)
            {  //sayi1 büyükse sayi1 değeri dön
                return sayi1;

            }
            else
            {   //sayi 2 büyükse sayi2 değeri dön
                return sayi2;
            }

        }

        static int Karsilastir3(int sayi1, int sayi2)
        {
            return sayi1 > sayi2 ? sayi1 : sayi2;
        }

        static double KareAl(double sayi)
        {
            double kare = sayi * sayi;
            return kare;
        }

        // Params çoklu değer alır 
        static double SeriToplami(params double[] seri)
        {
            double toplam = 0;
            foreach (double s in seri)
            {
                toplam += s;
            }

            return toplam;
        }


    //Method Overloadin method aşırı yüklenmesi
    /// <summary>
    /// Satış yapan fonksiyon
    /// </summary>
    /// <param name="miktar"></param>
    /// <param name="indirim"> </param>
    /// <returns> </returns>
    static double SalesUs(double miktar=0)
        {
            return miktar * 1.18;
        }
    /// <summary>
    /// Satış yapan fonksiyon
    /// </summary>
    /// <param name="miktar"></param>
    /// <param name="indirim"> </param>
    /// <returns> </returns>
    static double SalesUs(double miktar, double indirim)
        {
            return miktar * (1.0 - indirim) * 1.18;
        }
    }

