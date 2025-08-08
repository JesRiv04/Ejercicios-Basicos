using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            double Total = 0, Salario, Horas;

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Ingrese las horas trabajadas para el empleado " + i + ":");
                Horas = double.Parse(Console.ReadLine());

                Salario = Horas * 100;
                Total += Salario;
            }

            Console.WriteLine("El salario total es: $" + Total);
            Console.WriteLine();
        }
    }
}
