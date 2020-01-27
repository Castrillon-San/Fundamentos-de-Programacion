using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su c");
            double c = double.Parse(Console.ReadLine());

            double d = (b * b) - (4 * a * c);
            double x1 = (-b + (Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a);
            double x2 = (-b - (Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a);
            if (d == 0){
                Console.WriteLine("Tiene una unica solucion y es: " + x1);
            }
            else if (d > 0)
            {
                Console.WriteLine("Tiene dos posibles soluciones y son " + x1 + x2);
            }
            else
            {
                Console.WriteLine("No tiene solución");
            }
        }
    }
}
