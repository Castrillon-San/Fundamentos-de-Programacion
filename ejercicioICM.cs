using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class ejercicioICM
    {
        static void Main(string[] args)
        {
            //declarar los datos
            Console.WriteLine("Ingrese su peso actual: ");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su altura actual: ");
            double a = double.Parse(Console.ReadLine());

            //hallar imc
            double imc = p / (a * a);

            Console.WriteLine("Su indice de masa corporal es: " + imc);

            if (imc < 18.5)
            {
                Console.WriteLine("Usted se encuentra bajo peso");
            }
            else if (18.5 <= imc && imc <= 24.9)
            {
                Console.WriteLine("Usted se encuentra normal");
            }
            else if (24.9<= imc && imc <= 29.9)
            {
                Console.WriteLine("Usted se encuentra en Sobre peso");
            }
            else
            {
                Console.WriteLine("Usted se encuentra obeso");
            }
        }
    }
}
