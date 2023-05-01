using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    /* Escriba un programa que solicite dos números enteros (mínimo y máximo). A
continuación, se debe pedir al usuario que ingrese números enteros situados entre el
máximo y mínimo. Cada vez que un número se encuentre entre ese intervalo, se sumara
uno a una variable. El programa terminará cuando se escriba un número que no
pertenezca a ese intervalo, y al finalizar se debe mostrar por pantalla la cantidad de
números ingresados dentro del intervalo. */

    internal class Program
    {
        static void Main(string[] args)
        {
            int num=0, min, max;
            int contador=1;

            Console.WriteLine("Ingrese una cantidad minima de numeros enteros");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese una cantidad maxima de numeros enteros");
            max = int.Parse(Console.ReadLine());

            num = num + min;

            while (num >= min && num <= max)
            {
                Console.WriteLine("Ingrese un numero:");
                num = int.Parse(Console.ReadLine());
                contador= contador + 1;
            }

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("La cantidad de numero ingresados es: "+contador );

            Console.ReadKey();



        }
    }
}
