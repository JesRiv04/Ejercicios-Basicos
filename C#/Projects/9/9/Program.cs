using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            bool EsPrimo = true;

            Console.WriteLine("Ingrese un número:");
            N = int.Parse(Console.ReadLine());

            if (N < 2)
            {
                EsPrimo = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(N); i++)
                {
                    if (N % i == 0)
                    {
                        EsPrimo = false;
                        break;
                    }
                }
            }

            if (EsPrimo)
            {
                Console.WriteLine("Es primo");
            }
            else
            {
                Console.WriteLine("No es primo");
            }
            Console.WriteLine();
        }
    }
}
