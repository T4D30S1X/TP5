using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6
{
    /* Escriba un programa que solicite al usuario números decimales mientras que el usuario
escriba números mayores al primero que se ingresó. Por ejemplo: si el usuario ingresa
como primer número un 3.1, y luego ingresa un 4, el programa debe solicitar un tercer
número. El programa continuará solicitando valores sucesivamente mientras los valores
ingresados sean mayores que 3.1, caso contrario, el programa finaliza. */

    internal class Program
    {
        static void Main(string[] args)
        {
            float min = 0, num;

            Console.WriteLine("Ingrese un numero minimo para la cadena de numeros");
            min = float.Parse(Console.ReadLine());
            num = min;

           

           do
            {
                Console.WriteLine("Ingrese un numero:");
                num = float.Parse(Console.ReadLine());

            } while (num >= min) ;

                Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("El numero ingresado: " +num+" es menor al minimo ingresado: "+min);

            Console.ReadKey();

        }
    }
}
