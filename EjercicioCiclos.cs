using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Console.WriteLine("Ingrese el numero de datos (n): ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, max = 0, min = 200;
            string nombre = "", nmax = "", nmin = "";

            while (i < n)
            {
                Console.WriteLine("Edad: ");
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Nombre: ");
                nombre = Console.ReadLine();

                if (edad > max)
                {
                    max = edad;
                    nmax = nombre;
                }
                if (edad < min)
                {
                    min = edad;
                    nmin = nombre;
                }

                total += edad;
                i++;
            }
            double promedio = total / n;
            Console.WriteLine("Promedio = " + promedio);
            Console.WriteLine("Mayor = " + max + "Nombre: " + nmax);
            Console.WriteLine("Menor = " + min + "Nombre: " + nmin);
        }
    }
}
