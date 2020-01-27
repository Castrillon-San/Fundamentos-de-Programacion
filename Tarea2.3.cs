﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datos
            Console.WriteLine("Ingrese el valor del lado w: ");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del angulo d: ");
            double dGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del lado x: ");
            double x = double.Parse(Console.ReadLine());


            //Angulo d a radianes
            double d = dGrados * (Math.PI / 180.0);

            //Cateto P
            double p = (Math.Sin(d) * w);

            //Cateto y
            double y = p - x;

            //Resultado
            Console.WriteLine("El valor del lado y es de: " + p);
                   
        }
    }
}
