using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            Random aleatorio = new Random();

            int a = 0, b = 0, sumaCorrecta = 0, suma = 0, contador = 0, siContinuar = 0;
            a = aleatorio.Next(1, 11);
            b = aleatorio.Next(1, 11);
            sumaCorrecta = a + b;
           
            Console.WriteLine("Buenas compruebe si es humano con la siguiente suma: " + a + "+" + b);
            suma = int.Parse(Console.ReadLine());

            while (suma != sumaCorrecta)
            {
                
                Console.WriteLine("Vuelva a intentar");

                a = aleatorio.Next(1, 11);
                b = aleatorio.Next(1, 11);
                sumaCorrecta = a + b;

                Console.WriteLine("Buenas compruebe si es humano con la siguiente suma: " + a + "+" + b);
                suma = int.Parse(Console.ReadLine());

                if (contador == 2)
                {
                    Console.WriteLine("Validacion Incorrecta no puede continuar");
                    siContinuar = 1;
                    break;
                }
                contador++;
            }
            if (siContinuar == 0)
            {
                Console.WriteLine("Puede continuar");
                int carta = 0, total = 0;
                string continuar = "s";

                carta = aleatorio.Next(1, 11);
                total += carta;
                Console.WriteLine("Carta 1 = " + carta);
                carta = aleatorio.Next(1, 11);
                total += carta;
                Console.WriteLine("Carta 2 = " + carta);

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
}
