using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class TareaBlackJack
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta = 0, total = 0;
            string continuar = "s";

            carta = aleatorio.Next(1, 11);
            total += carta;   

            carta = aleatorio.Next(1, 11);
            total += carta;

            Console.WriteLine("Su total inicial por ambas cartas es de: " + total);

            while (continuar == "s" && total < 22)
            {
                carta = aleatorio.Next(1, 11);
                Console.WriteLine("Carta = " + carta);
                total += carta;
                if (total > 21) Console.WriteLine("Fuiste Eliminado");
                else
                {
                    Console.WriteLine("Total = " + total);
                    Console.WriteLine("Desea continuar? Presione s para sí, n para no");
                    continuar = Console.ReadLine();

                }
            }
            Console.WriteLine("Gracias por jugar");

        }
    }
}
