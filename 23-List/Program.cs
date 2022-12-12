using System;
using System.Collections;
using System.Collections.Generic;

namespace _23_List
{
    
    public class Araba<T> : IEnumerable //kalıtımdan devir alır.
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException(); //ınterface tasarladık
        }
    }

    
    
    public interface ISehır  //Interface kontrattır
    {
        void Tanit();
        void NüfusBilgisiGetir(int plakaNo);

    }
    public class Sehir : IComparable <Sehir>
    {   

        public Sehir(int plakaNo,string sehirAdi) //default constractor
        {
            PlakaNo = plakaNo;
            SehirAdi = sehirAdi;
        }


        public int PlakaNo { get; set; }
        public string SehirAdi { get; set; }

        public int CompareTo(Sehir other) // ikinci interface burada
        {
            if (this.PlakaNo < other.PlakaNo)
            {
                return -1;
            }
            else if(this.PlakaNo== other.PlakaNo)
            {
                return 0;
            }
            else { return 1; }
        }

       

        public override string ToString()
        {
            return $"{PlakaNo,-5},{SehirAdi,-15}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //List
            var sayilar = new List<int>() { 53,40,14,2,3,12,15}; //Liste ekledik
       
            sayilar.Sort(); //Sıralama metodu
            sayilar.ForEach(s => Console.WriteLine(s));

            //Sehir Listesi
            var sehirler = new List<Sehir>()
            {
                new Sehir(46,"Kahramanmaraş"),
                new Sehir(6,"Ankara"),
                new Sehir(34,"İstanbul"),
                new Sehir(23,"Elazığ"),
                new Sehir(44,"Malatya"),
            };
            sehirler.Add(new Sehir(1, "Adana"));
            sehirler.Sort(); //Sıralama metodu başarızı oldu compare to ile ayarlandı 
            sehirler.ForEach(s => Console.WriteLine(s));

            Console.ReadKey();
        }
    }
}
