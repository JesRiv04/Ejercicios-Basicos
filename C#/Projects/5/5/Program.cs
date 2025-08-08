using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Double A=0;
            Double V=0;
            Double PI = 3.14;
            Console.WriteLine("Ingrese el valor del Radio:");
            Double R = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la Altura:");
            Double H = int.Parse(Console.ReadLine());
            A=2*PI*R*(R+H);
            V = PI *  (R*R) * H;
            Console.WriteLine("El area es:" + A);
            Console.WriteLine("El volumen es:" + V);
            Console.ReadLine();
        }
    }
}
