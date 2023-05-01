using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace TP7
{
    /* Calcular las calificaciones de un grupo de alumnos. La nota final de cada alumno se
calcula según el siguiente criterio: se promediarán las notas obtenidas en la parte
práctica; la parte de problemas y la parte teórica. El programa leerá el nombre del
alumno, las tres notas obtenidas, mostrará el resultado por pantalla, y a continuación
volverá a pedir los datos del siguiente alumno hasta que el nombre sea una cadena
vacía. Las notas deben estar comprendidas entre 0 y 10, y si no están dentro de ese
rango no se imprimirá el promedio y se mostrará un mensaje de error. */

    internal class Program
    {
        static void Main(string[] args)
        {
            int practica, problema = 1, teorica = 1;
            float promedio;
            string nombre, salir="";


            do
            {
                Console.WriteLine("Ingrese el nombre del alumno");
                nombre = Console.ReadLine();
                Console.WriteLine();
                if (nombre == salir) 
                {
                    break;
                }
                else 
                {
                    do
                    {
                        Console.Write("Ingrese la nota en la parte de Practicas: ");
                        practica = int.Parse(Console.ReadLine());

                        if (practica < 0 || practica > 10)
                        {
                            Console.WriteLine("ERROR");
                        }
                    } while (practica < 0 || practica > 11);

                    Console.WriteLine();

                    do
                    {
                        Console.Write("Ingrese la nota en la parte de Problemas: ");
                        problema = int.Parse(Console.ReadLine());

                        if (problema < 0 || problema > 10)
                        {
                            Console.WriteLine("ERROR");
                        }
                    } while (problema < 0 || problema > 10);

                    Console.WriteLine();

                    do
                    {
                        Console.Write("Ingrese la nota en la parte de Teoricas: ");
                        teorica = int.Parse(Console.ReadLine());

                        if (teorica < 0 || teorica > 10)
                        {
                            Console.WriteLine("ERROR");
                        }
                    } while (teorica < 0 || teorica > 10);

                    promedio = (practica + problema + teorica) / 3;

                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine();

                    Console.WriteLine("El promedio del alumno " + nombre + " es de: " + promedio);

                    Console.WriteLine();
                     Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine();

                }

            } while (salir!=nombre);


        }
    }
}

