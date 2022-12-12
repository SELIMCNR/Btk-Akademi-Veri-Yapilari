using System;
using System.Collections;
using System.Collections.Generic;

namespace _30_Hash_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System .COLLECTİON.GENERİC sınıfı altında yer alır.
            // generic -> Boxing/uboxing yok <T> yani tip güvenliği

            /* eleman benzersizdir.
            sıralama yok farklılıkığ 
            Küme işlemleri var 
            A.unionwith(b) birleştirme
            A.Intersectwith(b) Kesişim
            A.Exceptwith(B) -> Sadece A dakiler 
            B.Exceptwith(A) -> Sadece B dekiler
            A.Symmetric Exceptwith(B) -> Kesişim dışındakiler
             */

            //HashSetUygulaması
            //Tanımlama
            var sesliHarf = new HashSet<char>(){
                'e','ı','i','u','ü','o','ö','b'
            };
            KoleksiyonYazdir(sesliHarf);
            //ekleme
            sesliHarf.Add('a');
            KoleksiyonYazdir(sesliHarf);

            //Listeden çıkarma 
            sesliHarf.Remove('b');
            KoleksiyonYazdir(sesliHarf);


            var alfabe= new List<char>();
            for (int i = 97; i < 123; i++)
            {
                alfabe.Add((char)i);
            }

            KoleksiyonYazdir(alfabe);
            //alfabe.ForEach(k => Console.WriteLine(k));


            //Türkçede kullanılan sesli harfler
            sesliHarf.ExceptWith(alfabe); // Sadece birinde olan
            sesliHarf.UnionWith(alfabe); // birleşim
            sesliHarf.IntersectWith(alfabe); // kesişim
            sesliHarf.SymmetricExceptWith(alfabe);//kesişim dışındakiler
            KoleksiyonYazdir(sesliHarf);


            Console.ReadKey();

            

        }
    
        static void KoleksiyonYazdir(IEnumerable koleksiyon){
            Console.WriteLine();
            int i = 0;
            foreach (char k in koleksiyon)
            {
                Console.WriteLine($"{k,5}");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("Eleman sayisi: {0}",i);
        }
    }
}
