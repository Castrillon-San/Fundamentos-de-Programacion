using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            string seguir = "";
            int dadoUno = 0;
            int dadoDos = 0;
            int contador = 0;
            int contadorDos = 1;
            int contadorTres = 0;

            dadoUno = aleatorio.Next(1, 7);
            dadoDos = aleatorio.Next(1, 7);
            int total = (dadoUno + dadoDos);

            Console.WriteLine("el valor del dado uno : " + dadoUno + " y del dado dos: " + dadoDos);
            Console.WriteLine("el total es: " + total);

            Console.WriteLine("¿Desea tirar otra vez? (s/n)");
            seguir = Console.ReadLine();



            while (seguir == "s" && total < 100)
            {
                contadorDos++;
                dadoUno = aleatorio.Next(1, 7);
                dadoDos = aleatorio.Next(1, 7);
                total += (dadoUno + dadoDos);
                Console.WriteLine("el valor del dado uno : " + dadoUno);
                Console.WriteLine("el valor del dado dos : " + dadoDos);
                Console.WriteLine("el total actual es : " + total);
                bool A = (dadoUno == dadoDos);

                if (dadoUno + dadoDos > 6) contador++;
                if (dadoUno != dadoDos)
                {
                    contadorTres = 0;


                }
                else if (A && dadoUno != 1)
                {
                    contadorTres++;
                    //Console.WriteLine("contadorTres: " + contadorTres);
                    if (contadorTres == 3) Console.WriteLine("Win");

                }
                if (dadoUno == 1 && dadoDos == 1)
                {


                    Console.WriteLine("Game Over");
                    seguir = "n";

                }
                else if (total < 100) {
                    if (contadorTres == 3) { seguir = "n";  } else
                    {
                        Console.WriteLine("¿Desea tirar otra vez? (s/n)");
                        seguir = Console.ReadLine();

                    }


                } else
                {


                    Console.WriteLine("Win");
                }


            }

            Console.WriteLine("el total de dados es: " + total);
            Console.WriteLine("gracias por participar");
            double porcentaje = (((double)contador) / contadorDos) * 100;
            Console.WriteLine("porcentaje de veces que la la suma fue mayor a 6: " + porcentaje + "%");
           
        }
    }
}
