using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datos
            Console.WriteLine("Ingrese el valor del angulo d: ");
            double dGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del angulo b: ");
            double bGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del cateto y: ");
            double y = double.Parse(Console.ReadLine());

            //Angulo e 
            double eGrados = 180.0 - (dGrados + bGrados);

            //Angulo c en radianes
            double cGrados = 180.0 - eGrados;
            double c = cGrados * (Math.PI / 180.0);

            //Cateto z
            double z = ((Math.Tan(c)) * y);

            //Resultado
            Console.Write("El valor del cateto z es: " + z);
            
        }
    }
}
