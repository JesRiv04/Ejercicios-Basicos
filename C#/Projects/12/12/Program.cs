using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 1, C = 0, S = 0;
            double P;

            Console.WriteLine("Ingrese una nota (ingrese 0 para finalizar):");
            N = int.Parse(Console.ReadLine());

            while (N != 0)
            {
                S += N;
                C++;
                Console.WriteLine("Ingrese una nota (ingrese 0 para finalizar):");
                N = int.Parse(Console.ReadLine());
            }

            if (C > 0)
            {
                P = (double)S / C;
                Console.WriteLine("El promedio es: " + P);
            }
            else
            {
                Console.WriteLine("No se ingresaron notas.");
            }
            Console.WriteLine();
        }
    }
}
