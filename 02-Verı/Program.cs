using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Verı
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double x;
x = 2.5;

var y = 2 * x;
Console.WriteLine(y.GetType()); //Mevcut örneğin tipini getirir.


Console.WriteLine(y);


var n = "2";
var m = "3";
var l = n + m;  // + işareti string ifadeleri birleştirir.
Console.WriteLine(l.GetType());
Console.WriteLine(l);

Console.ReadKey();



        }
    }
}
