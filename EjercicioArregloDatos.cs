using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ingrese el numero de datos: ");
            int n = int.Parse(Console.ReadLine());
            string[] nombres = new string[n];
            int[] edades = new int[n];
            string mayor = "", menor = "", nombreCercano="";
            int max = 0, min = 200, suma = 0; 
            double promedio= 0, desviacion=0, cercano = 1000, desvi = 100, suma2 = 0;
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("ingrese su nombre: ");
                nombres[i] = Console.ReadLine();

                Console.WriteLine("ingrese su edad: ");
               
                edades[i] = int.Parse(Console.ReadLine());

                if (edades[i] < min)
                {
                    min = edades[i];
                    menor = nombres[i];
                }

                if (edades[i] > max)
                {
                    max = edades[i];
                    mayor = nombres[i];
                }
             
            }
            Console.WriteLine("el mayor es: "+ mayor + " con: "+ max +" años.");
            Console.WriteLine("el menor es: " + menor + " con: " + min + " años.");
            for (int i = 0; i < nombres.Length; i++)
            {
                suma += edades[i];
                promedio = suma / n;
            
            }
            Console.WriteLine("el promedio es: " + promedio);
            for (int i = 0; i < nombres.Length; i++)
            {
                suma2 += Math.Pow((suma - promedio), 2) / n;
                desviacion = Math.Sqrt(suma2);
            }
            for (int i = 0; i < nombres.Length; i++)
            {
                desvi = Math.Sqrt(Math.Pow((edades[i] - promedio), 2));
                if (desvi < cercano)
                {
                    cercano = desvi;
                    nombreCercano = nombres[i];
                }
            }
            Console.WriteLine("la desviacion es: " + desviacion);
            Console.WriteLine("la edad mas cercana es : " + cercano + " de " + nombreCercano);

        }

    }
}
