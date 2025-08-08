using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            double G = 15, S = 20, R = 25, P1, P2, P3, C, Total, D, C2;

            Console.WriteLine("Cantidad de Gansitos:");
            C = double.Parse(Console.ReadLine());
            P1 = G * C;

            Console.WriteLine("Cantidad de Sabritas:");
            C = double.Parse(Console.ReadLine());
            P2 = S * C;

            Console.WriteLine("Cantidad de Refresco:");
            C = double.Parse(Console.ReadLine());
            P3 = R * C;

            Total = P1 + P2 + P3;

            Console.WriteLine("Cantidad Recibida del cliente:");
            D = double.Parse(Console.ReadLine());

            C2 = D - Total;

            Console.WriteLine("El cambio es: $" + C2);
            Console.WriteLine();
        }
    }
}
