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
            Console.WriteLine("Ingrese números de votos del Partido 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese números de votos del Partido 2");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese números de votos en blanco");
            int blancos = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese números de votos anulados");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese números de población de todas las edades");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el porcentaje (de 0 a 100%) de la poblacion que es mayor de edad");
            int p = int.Parse(Console.ReadLine());

            int votos = a + b + blancos + anulados;

            int abstencion = (n * p / 100) - votos;

            bool A = anulados < ((votos) * 0.3);
            bool B = (a+b) > blancos;
            bool C = abstencion < votos;

            if ((A || B) && C)
            {
                Console.WriteLine("Las votaciones fueron exitosas");
                if (a > b) Console.WriteLine("El Partido 1 es el ganador");
                else Console.WriteLine("El Partido 2 es el ganador");
            }
            else Console.WriteLine("Las elecciones deben ser realizadas nuevamente");
        }
    }
}
