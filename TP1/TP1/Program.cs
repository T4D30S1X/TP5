using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    /* Escriba un programa que valide si una nota está entre 0 y 10, sino está entre 0 y 10 la nota se pedirá de
nuevo hasta que la nota sea correcta. */

    internal class Program
    {
        static void Main(string[] args)
        {
            int nota;


            do
            {
                Console.WriteLine("Ingrese la nota");
                nota = int.Parse(Console.ReadLine());
               
            } while (nota < 0 || nota>10);

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("La nota se encuentra entre 0 y 10 ");

            Console.ReadKey();
        }
    }
}
