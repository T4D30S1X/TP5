using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8
{
    /* Escribir un programa que calcule cuántos dígitos tiene un número entero positivo.
(pista: se puede hacer dividiendo varias veces entre 10). */

    internal class Program
    {
        static void Main(string[] args)
        {
            int n,num,contador=0;

            Console.WriteLine("Ingresar un numero entero positivo");
            n = int.Parse(Console.ReadLine());
            num = n;
           
            while(n >= 1)
            {
                n = n / 10;
                contador++;
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("El numero: " + num + " tiene "+contador+" digitos");

            Console.ReadKey();
        }
    }
}
