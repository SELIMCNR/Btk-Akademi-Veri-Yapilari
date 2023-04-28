using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OPERATORLE
{
    internal class Program
    {
          private static void Main(string[] args)
    {
        int sayi1 = 20, sayi2 = 10;

        //Aritmetik operatörler 
        Console.WriteLine(sayi1 + sayi2);
        Console.WriteLine(sayi1 - sayi2);
        Console.WriteLine(sayi1 * sayi2);
        Console.WriteLine(sayi1 / sayi2);
        Console.WriteLine(sayi1 % sayi2); // % kalan bulma mod


        //İlişkisel operatörler 
        Console.WriteLine(sayi1 > sayi2);
        Console.WriteLine(sayi1 < sayi2);
        Console.WriteLine(sayi1 >= sayi2);
        Console.WriteLine(sayi1 <= sayi2);
        Console.WriteLine(sayi1 == sayi2);
        Console.WriteLine(sayi1 != sayi2);


        //Mantıksal operatörler
        Console.WriteLine(sayi1 > sayi2 && sayi1 > 5);
        Console.WriteLine(sayi1 < sayi2 || sayi2 > 5);



        Console.ReadKey();
    }
    }
}
