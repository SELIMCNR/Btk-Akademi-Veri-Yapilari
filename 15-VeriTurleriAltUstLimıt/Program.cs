using System;

namespace _15_VeriTurleriAltUstLimıt
{
    internal class Program
    {
        static void Main(string[] args)
        {    // 8-bit integer 
            Console.WriteLine(nameof(SByte)); // veri türünü yazdırır.
            Console.WriteLine($"Alt limit    :{SByte.MinValue}");//Veri türünün en küçük değeri
            Console.WriteLine($"Üst limit    :{SByte.MinValue}");//Veri türünün en büyük değeri
            Console.WriteLine($"Boyut        :{sizeof(SByte),20}");
            Console.ReadKey();

            Console.WriteLine();

            // Unsigned 8-bit integer 
            Console.WriteLine(nameof(Byte)); // veri türünü yazdırır.
            Console.WriteLine($"Alt limit    :{Byte.MinValue}");//Veri türünün en küçük değeri
            Console.WriteLine($"Üst limit    :{Byte.MinValue}");//Veri türünün en büyük değeri
            Console.WriteLine($"Boyut        :{sizeof(Byte),20}");
            Console.ReadKey();


            // signed 16-bit integer 
            Console.WriteLine(nameof(Int16)); // veri türünü yazdırır.
            Console.WriteLine($"Alt limit    :{Int16.MinValue}");//Veri türünün en küçük değeri
            Console.WriteLine($"Üst limit    :{Int16.MinValue}");//Veri türünün en büyük değeri
            Console.WriteLine($"Boyut        :{sizeof(Int16),20}");
            Console.ReadKey();


            // Unsigned 16-bit integer 
            Console.WriteLine(nameof(UInt16)); // veri türünü yazdırır.
            Console.WriteLine($"Alt limit    :{UInt16.MinValue}");//Veri türünün en küçük değeri
            Console.WriteLine($"Üst limit    :{UInt16.MinValue}");//Veri türünün en büyük değeri
            Console.WriteLine($"Boyut        :{sizeof(UInt16),20}");
            Console.ReadKey();



            // Unsigned 32-bit integer 
            Console.WriteLine(nameof(Int32)); // veri türünü yazdırır.
            Console.WriteLine($"Alt limit    :{Int32.MinValue}");//Veri türünün en küçük değeri
            Console.WriteLine($"Üst limit    :{Int32.MinValue}");//Veri türünün en büyük değeri
            Console.WriteLine($"Boyut        :{sizeof(Int32),20}");
            Console.ReadKey();


            //Double 
            Console.WriteLine(nameof(Double)); // veri türünü yazdırır.
            Console.WriteLine($"Alt limit    :{Double.MinValue}");//Veri türünün en küçük değeri
            Console.WriteLine($"Üst limit    :{Double.MinValue}");//Veri türünün en büyük değeri
            Console.WriteLine($"Boyut        :{sizeof(Double),20}");
            Console.ReadKey();

        }
    }
}
