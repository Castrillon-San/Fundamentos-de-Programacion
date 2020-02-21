using System;

namespace TareaSimulacroWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            string seguir = "";
            int dadoUno = 0;
            int dadoDos = 0;
            int contadorVidas = 3;
            int contadorTurnos1 = 1;
            int contadorTurnos2 = 1;

            dadoUno = aleatorio.Next(1, 7);
            int total = (dadoUno + dadoDos);

            Console.WriteLine("el valor del dado uno es: " + dadoUno);
            Console.WriteLine("el total es: " + total);
            Console.WriteLine("Cuenta con un total de vidas de: " + contadorVidas);

            Console.WriteLine("¿Desea tirar otra vez? (s/n)");
            seguir = Console.ReadLine();



            while (seguir == "s" && total < 100)
            {
                contadorTurnos1++;
                contadorTurnos2++;
                dadoUno = aleatorio.Next(1, 7);
                total += dadoUno;
                Console.WriteLine("el valor del dado uno es: " + dadoUno);
                Console.WriteLine("el total actual es : " + total);
                Console.WriteLine("Cuenta con un total de vidas de: " + contadorVidas);

                if (contadorTurnos1 == 2)
                {
                    contadorVidas--;
                    contadorTurnos1 = 0;
                }

                if (contadorTurnos2 == 3)
                {
                    dadoDos = aleatorio.Next(1, 7);
                    total += dadoDos;
                    contadorTurnos2 = 0;

                    if (dadoUno == dadoDos)
                    {
                        contadorVidas++;
                    }
                    Console.WriteLine("el valor del dado dos es: " + dadoDos);
                    Console.WriteLine("el total actual es : " + total);
                    Console.WriteLine("Cuenta con un total de vidas de: " + contadorVidas);
                }
               
                if (contadorVidas == 0)
                {
                    Console.WriteLine("Game Over");
                    seguir = "n";

                }
                else if (total < 100)
                {
                        Console.WriteLine("¿Desea tirar otra vez? (s/n)");
                        seguir = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Win");
                }
            }
            Console.WriteLine("el total de dados es: " + total);
            Console.WriteLine("gracias por participar");
        }
    }
}
