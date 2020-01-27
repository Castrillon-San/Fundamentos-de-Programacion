using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datos 
            Console.WriteLine("Ingrese el valor de la hipotenusa w: ");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la hipotenusa t: ");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del angulo c: ");
            double cGrados = double.Parse(Console.ReadLine());

            //Angulo c a radianes
            double c = cGrados * (Math.PI / 180.0);

            //Angulo a y convertirlo a radianes
            double aGrados = 180.0 - (90.0 + cGrados);
            double a = aGrados * (Math.PI / 180.0);

            //Angulo e 
            double eGrados = 180.0 - cGrados;

            //Cateto z
            double z = (Math.Cos(a) * t);

            //Valor de y
            double y = (Math.Sin(a) * t);

            //Angulo AB
            double ab = (Math.Acos(z / w));
            double abGrados = ab * (180.0 / Math.PI);

            //Hallar el valor de x 
            double x = (Math.Sin(ab) * w) - y;

            //Resultado
            Console.WriteLine("El valor del lado x es:" + x);
            
        }
    }
}
