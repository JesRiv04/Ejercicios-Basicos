using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Double R = 0;
            Console.WriteLine("Ingrese un Valor:");
            int N = int.Parse(Console.ReadLine());
            R = 2 % N;
            if (R == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
        }
    }
}
