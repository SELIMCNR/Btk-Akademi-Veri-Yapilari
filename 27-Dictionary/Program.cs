using System;
using System.Collections.Generic;

namespace _26_Dictionary
{
    internal class Program
    {
        public class Personel
        {
            public Personel(string name, string surname, decimal mass)
            {
                Name = name;
                Surname = surname;
                Mass = mass;
            }

            public int SicilNo { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }

            public decimal Mass { get; set; }

            public override string ToString()
            {
                return $"{Name,-10} {Surname,-15} {Mass,-10}";
            }

        }

        static void Main(string[] args)
        {
            //Dictionary
            var personelListesi = new Dictionary<int, Personel>();
            personelListesi.Add(100, new Personel("Selim", "Çınar", 10000));

            //Tanım2
            var personelListesi2 = new Dictionary<int, Personel>()
            {
                {110, new Personel("Mehmet","Sonsoz",7500) },
                {120, new Personel("Ahmet","Can",9000) }
            };


            //dolaşma
            foreach (var p in personelListesi)
            {
                Console.WriteLine(p);
            }

            DictionaryTemel();
            Console.ReadKey();
        }

        private static void DictionaryTemel()
        {
            //Dictionary <TKey,TValue 
            // System-collections-generic sınıfı altında yer alır.
            // boxing->unboxing yok system generic sınıfında
            // Tkey - Tvalue ,anahtar -değer çifti 
            //Tkey benzersiz -> Tvalue istediğiniz  
            // Hashtable göre daha performanslı çalışır.

            //Dictionary tanım 
            var telefonKodlari = new Dictionary<int, string>();


            //Dictionary tanım 2 
            var telefonKodlari2 = new Dictionary<int, string>()
            {
                {302,"Konya" },
                {421,"Elazığ" },
                {466,"Art" }
            };

            //Ekleme 
            telefonKodlari2.Add(322, "Kahramanmaraş");
            telefonKodlari2.Add(321, "Osmaniye");
            telefonKodlari2.Add(212, "İstanbul");
            telefonKodlari2.Add(211, "Edirne");

            //Değiştirme
            telefonKodlari2[321] = "Artvin";

            //Contains Key anahtar sorgusu
            if (!telefonKodlari2.ContainsKey(321))
            {
                Console.WriteLine("\a Artvin'nin kod bilgisi yok");
                telefonKodlari2.Add(321, "Bolu");
                Console.WriteLine("Yeni kod eklendi");
            }

            //Contains Value value değer sorgusu
            if (!telefonKodlari2.ContainsValue("İstanbul"))
            {
                Console.WriteLine("\a İstanbul ' un kod bilgisi yok.");
                telefonKodlari2.Add(212, "İstanbul");
                Console.WriteLine("Yeni kod eklendi");
            }

            //Erişme 
            foreach (var s in telefonKodlari2)
            {
                Console.WriteLine(s);
            }
        }
    }
}
