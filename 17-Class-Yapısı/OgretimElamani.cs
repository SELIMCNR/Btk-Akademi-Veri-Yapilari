using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Class_Yapısı
{
    public class OgretimElamani
    {
        //Property-Özellik Class özellikleri
        //Propert seç generic constu seç ve yapılandırıcı metodu oluştursun.
        public int SicilNo { get; set; }
        public String Adi { get; set; }
        public String Soyadi { get; set; }

        public bool Cinsiyet { get; set; }
    
        //Default ctor
        public OgretimElamani()
        {
            Console.WriteLine("Otomatik çalıştı.");
        }
        public OgretimElamani(int sicilNo, string adi, string soyadi, bool cinsiyet)
        {
            SicilNo = sicilNo; //classda bilgiyi parametreye ekledik
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }

        public override string ToString()
        {
            return $"{SicilNo,-5}" +
                $"{Adi,-10}" +
                $"{Soyadi,-10}" +
                string.Format("{0,-8}", Cinsiyet == true ? "Bay" : "Bayan");
                
        }
    }
}
