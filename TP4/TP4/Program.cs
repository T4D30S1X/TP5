using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    /* Escriba un programa en el cual se ingrese un número y mientras ese número sea mayor
de 10, se pedirá el número de nuevo. */

    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 11;

         while (num >10) 
            {
                Console.WriteLine("Ingrese un numero mayor a 10:");
                num=int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("El numero "+num+" es menor 10");

            Console.ReadKey();


        }
    }
}
