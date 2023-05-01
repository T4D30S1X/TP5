using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    /* Escriba un programa en el cual se ingrese un valor límite positivo, y a continuación
solicite números al usuario hasta que la suma de los números introducidos supere el
límite inicial. */

    internal class Program
    {
        static void Main(string[] args)
        {
            int num, limite, suma= 0;

            Console.WriteLine("Ingrese el limite de los numero positivos");
            limite = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine("Ingrese el numero");
                    num = int.Parse(Console.ReadLine());

                    suma = suma + num;
                } while (suma <= limite);


            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("La suma de la nota "+ suma+ " es mayor al limite propuesto ("+limite+")");

            Console.ReadKey();
        }
    }
}
