using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            double K, M;

            Console.WriteLine("Ingrese la velocidad en k/h:");
            K = double.Parse(Console.ReadLine());

            M = K * 5 / 18;

            Console.WriteLine("La velocidad en m/s es: " + M);
            Console.WriteLine();
        }
    }
}
