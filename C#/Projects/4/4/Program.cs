using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Double H = 0;
            Console.WriteLine("Ingrese el valor del Cateto A");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del Cateto B");
            int B = int.Parse(Console.ReadLine());
            H = A ^ 2 * B ^ 2;
            H = Math.Sqrt(H);
            Console.WriteLine("La hipotenusa es:" + H);
            Console.ReadLine();
        }
    }
}
