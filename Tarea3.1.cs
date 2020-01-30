using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de Datos
            Console.WriteLine("Ingrese su salario mensual");
            double salario = double.Parse(Console.ReadLine());

            //Identificar cantidad de salarios minimos mensuales
            double ssmlv = salario / 828116;

            //Resultado tarifa por condicionales
            if ( ssmlv < 2)
            {
                Console.WriteLine("Usted obtiene Tarifa A");
            }
            else if ( 2 <= ssmlv && ssmlv < 4)
            {
                Console.WriteLine("Usted obtiene Tarifa B");
            }
            else if (ssmlv <= 4)
            {
                Console.WriteLine("Usted obtiene Tarifa C");
            }

        }
    }
}
