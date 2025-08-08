using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            int T, ANOS = 0, Meses = 0, Semanas = 0, Dias;

            Console.WriteLine("Ingrese el número de días:");
            T = int.Parse(Console.ReadLine());

            if (T >= 365)
            {
                while (T >= 365)
                {
                    T -= 365;
                    ANOS++;
                }
            }

            if (T >= 30)
            {
                while (T >= 30)
                {
                    T -= 30;
                    Meses++;
                }
            }

            if (T >= 7)
            {
                while (T >= 7)
                {
                    T -= 7;
                    Semanas++;
                }
            }

            Dias = T;

            Console.WriteLine("El tiempo es: " + ANOS + " Años, " + Meses + " Meses, " + Semanas + " Semanas, " + Dias + " Días.");
            Console.WriteLine();
        }
    }
}
