using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, e = 0;
            Console.WriteLine("Ingrese su x");
            x = double.Parse(Console.ReadLine());

            for (int i = 0; i < 100; i++)
            {
                e += (Math.Pow(x, i))/Factorial(i);
            }
            //Console.WriteLine("Iteracion " + i);
            Console.WriteLine(e);
        }
        public static double Factorial(double number)
        {
            if (number == 0) return 1;
            if (number == 1) return 1;
            else return number * Factorial(number - 1);
        }
    }
}

