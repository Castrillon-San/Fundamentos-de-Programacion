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
            Console.WriteLine("Ingrese su frase");
            string frase = Console.ReadLine();
            frase = frase.ToUpper();

            string[] palabras = frase.Split(' ');

            Console.WriteLine("Ingrese su palabra");
            string palabraBuscada = Console.ReadLine();
            palabraBuscada = palabraBuscada.ToUpper();

            int contador = 0;
            for(int i = 0; i < palabras.Length; i++)
            {
                if(palabraBuscada == palabras[i])
                {
                    contador++;
                    Console.WriteLine("Se encuentra en la posicion " + i);
                }
            }
            Console.WriteLine("La palabra se repite " + contador + " veces");
        }
    }
}
