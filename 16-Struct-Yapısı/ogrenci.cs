namespace _16_Struct_Yapısı
{
    public struct Ogrenci
    {
        //Yapılandırıcı metot -Constructor
        public Ogrenci(int numara, string adi, string soyadi, bool cinsiyet = true) // true varsayılan değer eklendi
        {
            Numara = numara;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }

        //prop kısa yol
        public int Numara { get; set; } // Property - Özellik get-getirir ,set-okutur
        public string Adi { get; set; } // public dışardan erişime izin verir. private izin vermez
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }

        // Geçersiz kılmak / Ezmek / Override
        public override string ToString() // 
        {  //Console.writeline içerisine veri gönderiyor 
            return $"{Numara,-5} " +
                $"{Adi,-10} " +
                $"{Soyadi,-10}" +
                string.Format("{0,-5}", Cinsiyet == true ? "Bay" : "Bayan");
        
        }


    }
}