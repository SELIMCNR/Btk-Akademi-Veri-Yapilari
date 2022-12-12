using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OPERATORLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            A = 20;
            B = 10;

            // Aritmetik operatörler 
            Console.WriteLine(A-B);
            Console.WriteLine(A+B);
            Console.WriteLine(A*B);
            Console.WriteLine(A/B);
            Console.WriteLine(A%B);

            // İlişkisel operatörler
            Console.WriteLine(A>B);
            Console.WriteLine(A<B);
            Console.WriteLine(A>=B);
            Console.WriteLine(A<=B);
            Console.WriteLine(A==B);
            Console.WriteLine(A!=B);
            
            //MANTIKSAL 
            Console.WriteLine(A>B && A<5);
            Console.WriteLine(A<B || B>5);

            Console.ReadKey();
        }
    }
}
