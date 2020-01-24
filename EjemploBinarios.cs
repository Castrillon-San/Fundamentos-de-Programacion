using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //se piden los 5 datos

            Console.WriteLine("Ingrese su dato B4: ");
            double b4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su dato B3: ");
            double b3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su dato B2: ");
            double b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su dato B1: ");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su dato B0: ");
            double b0 = double.Parse(Console.ReadLine());

            //se hacen las operaciones

            double a = (b0 * Math.Pow(2, 0)) + (b1 * Math.Pow(2, 1)) + (b2 * Math.Pow(2, 2)) + (b3 * Math.Pow(2, 3)) + (b4 * Math.Pow(2, 4));

            //resultado

            Console.WriteLine("Su resultado es: " + a);

        }
    }
}
