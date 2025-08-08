using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
        int N;
        Console.WriteLine("Ingresa la Calificación:");
        N = int.Parse(Console.ReadLine());

        if (N > 0 && N < 21)
        {
            if (N > 18 && N < 21)
            {
                Console.WriteLine("La nota es A");
            }
            else if (N > 15 && N < 19)
            {
                Console.WriteLine("La nota es B");
            }
            else if (N > 12 && N < 16)
            {
                Console.WriteLine("La nota es C");
            }
            else if (N > 9 && N < 13)
            {
                Console.WriteLine("La nota es D");
            }
            else if (N > 0 && N < 10)
            {
                Console.WriteLine("La nota es E");
            }
            else
            {
                Console.WriteLine("La nota es invalida");
            }
        }
        else
        {
            Console.WriteLine("Calificación Invalida");
        }
        Console.WriteLine();

        }
    }
}
