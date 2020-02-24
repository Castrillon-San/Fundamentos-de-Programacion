using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, sin = 0;
            Console.WriteLine("Ingrese su x");
            x = double.Parse(Console.ReadLine());

            for (int i = 0; i < 1000; i++)
            {
                sin += (Math.Pow(-1, i) / Factorial((2 * i) + 1)) * (Math.Pow(x, (2 * i) + 1));
            }
            //Console.WriteLine("Interacion " + i);
            Console.WriteLine(sin);
        }
        public static double Factorial(double number)
        {
        if (number == 1) return 1;
            if (number == 1) return 1;
            else return number * Factorial(number - 1);
        }
        
    }
}
