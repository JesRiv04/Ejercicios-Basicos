using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            double Entrada, Salida, Tiempo, Monto;

            Console.WriteLine("Ingrese la hora de entrada: ");
            Entrada = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la hora de salida: ");
            Salida = double.Parse(Console.ReadLine());

            Tiempo = Salida - Entrada;

            if (Tiempo != Math.Truncate(Tiempo))
            {
                Tiempo = Math.Truncate(Tiempo) + 1;
            }

            if (Tiempo == 1)
            {
                Monto = 15;
            }
            else
            {
                Monto = 15 + (Tiempo - 1) * 10;
            }

            Console.WriteLine("El monto a pagar es: $" + Monto);
            Console.WriteLine();
        }
    }
}
