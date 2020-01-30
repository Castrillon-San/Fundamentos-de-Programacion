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
            //Ingreso de datos
            Console.WriteLine("Ingrese su salario mensual");
            double salario = double.Parse(Console.ReadLine());

            //Cálculo de Smmlv
            double ssmlv = salario / 877803;

            //Resultados por condicionales
            if (ssmlv < 2)
            {
                Console.WriteLine("Usted obtiene Tarifa A y el valor de cuota moderadora es de $3400");
            }
            else if (2 <= ssmlv && ssmlv < 5)
            {
                Console.WriteLine("Usted obtiene Tarifa B y el valor de cuota moderadora es de $13500");
            }
            else if (ssmlv >= 5)
            {
                Console.WriteLine("Usted obtiene Tarifa C y el valor de cuota moderadora es de $35600");
            }
        }
    }
}
