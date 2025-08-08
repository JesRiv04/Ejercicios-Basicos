using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            int BC = 0, BV = 0, BD = 0, BC2 = 0, BM = 0, C, Resto, N;

        Console.WriteLine("Ingrese el monto:");
        N = int.Parse(Console.ReadLine());

        C = N;

        while (C >= 50000)
        {
            BC++;
            C -= 50000;
        }

        while (C >= 20000)
        {
            BV++;
            C -= 20000;
        }

        while (C >= 10000)
        {
            BD++;
            C -= 10000;
        }

        while (C >= 5000)
        {
            BC2++;
            C -= 5000;
        }

        while (C >= 1000)
        {
            BM++;
            C -= 1000;
        }

        Resto = C;

        Console.WriteLine(N);
        Console.WriteLine(BC);
        Console.WriteLine(BV);
        Console.WriteLine(BD);
        Console.WriteLine(BC2);
        Console.WriteLine(BM);
        Console.WriteLine(Resto);
        }
    }
}
