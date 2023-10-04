using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO7_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i;

            for(i = 1; i <= 1000; i++)
            {
                if(i % 3 == 0)
                {
                    int divisor = i / 3;
                    Console.WriteLine("Divisor de Fiorella Romero " + divisor + " : " + i);

                }
            }
            Console.ReadKey();
        }
    }
}
