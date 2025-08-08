using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el Valor A:");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Valor B:");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Valor C:");
            int C = int.Parse(Console.ReadLine());

            if (A == B)
            {
                Console.WriteLine("A y B son iguales");
            }
            else
            {
                if (A == C)
                {
                    Console.WriteLine("A y C son iguales");
                }
                else
                {
                    if (B == C)
                    {
                        Console.WriteLine("B y C son iguales");
                    }
                    else
                    {
                        if (A > B)
                        {
                            if (A > C)
                            {
                                Console.WriteLine("A es Mayor");
                            }
                            else
                            {
                                Console.WriteLine("C es Mayor");
                            }
                        }
                        else
                        {
                            if (B > C)
                            {
                                Console.WriteLine("B es Mayor");
                            }
                            else
                            {
                                Console.WriteLine("C es Mayor");
                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
