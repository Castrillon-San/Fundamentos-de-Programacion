using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            //Ingreso del nombre
            Console.WriteLine("Ingrese x1");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese x2");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese y1");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese y2");
            double y2 = double.Parse(Console.ReadLine());

            double m = (y2 - y1) / (x2 - x1);

            double b = y1 - (m * x1);

            double d = Math.Sqrt((y2 - y1) * (y2 - y1) + (x2 - x1) * (x2 - x1));

            Console.WriteLine("Su pendiente es: " + m);
            Console.WriteLine("Su intercepto es: " + b);
            Console.WriteLine("Su distancia es: " + d);
            
            //Console.WriteLine(z);

        }
    }
}
