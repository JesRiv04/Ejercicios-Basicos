using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
        double A, B;
        Console.WriteLine("Ingresa el Primer número:");
        A = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa el Segundo número:");
        B = double.Parse(Console.ReadLine());

        if (A == B)
        {
            Console.WriteLine(A + " " + B);
        }
        else
        {
            if (A > B)
            {
                Console.WriteLine(B + " " + A);
            }
            else
            {
                Console.WriteLine(A + " " + B);
            }  
        }
        Console.WriteLine();
        }
    }
}
