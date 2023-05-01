using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    /* Dada una secuencia de números ingresados por teclado que finaliza con la entrada de
un número negativo, por ejemplo: 5,3,0,2,4,4,0,0,2,3,6,0,......,-1; realizar un
programa que calcule el promedio de los números ingresados.  */

    internal class Program
    {
        static void Main(string[] args)
        {
            float num, suma = 0, promedio;
            int aux = 0;

            do
            {
                Console.WriteLine("Ingrese el numero");
                num = int.Parse(Console.ReadLine());

                if (num>0) 
                {
                    suma = suma + num;
                    aux = aux + 1;

                }

            } while (num>0);

            promedio = suma / aux;

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("El promedio de los numeros ingresados es: "+promedio);

            Console.ReadKey();

        }
    }
}
