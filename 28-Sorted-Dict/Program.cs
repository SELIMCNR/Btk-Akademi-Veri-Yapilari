using System;
using System.Collections.Generic;

namespace _28_Sorted_Dict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dict ile aynı özellik ekstra eklemede sıralama işlemi de yapılır.
            var kitapIndeks = new SortedDictionary<string, List<int>>()
            {
                { "HTML",new List<int>() { 8,10,12}},
                {"CSS",new List<int>() { 70,80,90}},
                {"JQUERY",new List<int> { 3,5,15} },
                {"SQL",new List<int>{70,80} }
            };
            
            kitapIndeks.Add("FTP",new List<int> { 1, 2, 3 });
            kitapIndeks.Add("ASP.NET", new List<int>() { 50, 60 });
        
            foreach (var kavram in kitapIndeks)
            {
                Console.WriteLine(kavram.Key);
                foreach (int s in kavram.Value)
                {
                    Console.WriteLine($"\t > {s,-5} pp");
                }
                kavram.Value.ForEach(s => Console.WriteLine("\t " + s));
            }
          

        }
    }
}
