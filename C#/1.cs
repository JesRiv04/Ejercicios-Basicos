using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer Valor:");
            int V1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo Valor:");
            int V2 = int.Parse(Console.ReadLine());
            if (V1 > V2)
            {
                Console.WriteLine("El valor 1 es mayor");
            }
            else
            {
                Console.WriteLine("El valor 2 es mayor");
            }
            Console.ReadLine();
        }
    }
}
