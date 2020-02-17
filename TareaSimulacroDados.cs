using System;

namespace TareaSimulacroDados
{
    class Program
    {
        static void Main(string[] args)
        {
                //Datos Iniciales
                Random aleatorio = new Random();

                string seguir = "";
                int dadoUno = 0;
                int dadoDos = 0;
                int dadoTres = 0;
                int contador = 0;
                
                //Ronda Inicial de los Dados
                dadoUno = aleatorio.Next(1, 13);
                dadoDos = aleatorio.Next(1, 13);
                dadoTres = aleatorio.Next(1, 13);
                int total = (dadoUno + dadoDos + dadoTres);

                Console.WriteLine("el valor de la ronda uno es de: " + dadoUno + "Ronda dos: " + dadoDos + "Ronda tres: " + dadoTres);
                Console.WriteLine("el total es: " + total);

                Console.WriteLine("¿Desea tirar otra vez? (s/n)");
                seguir = Console.ReadLine();
                
                //Ciclo
                while (seguir == "s" && total < 100)
                {
                    dadoUno = aleatorio.Next(1, 13);
                    total += (dadoUno);
                    Console.WriteLine("el valor del dado es de: " + dadoUno);
                    Console.WriteLine("el total actual es : " + total);

                if (dadoUno == 10)
                {
                    contador += 1;
                }
                else contador = 0;

                if(contador == 1 && dadoUno == 12)
                {
                    Console.WriteLine("Win");
                    seguir = "n";
                }

                    if (total < 100)
                    {
                    seguir = "s";
                   
                        if (dadoUno % 2 == 0) {
                        Console.WriteLine("¿Desea tirar otra vez? (s/n)");
                        seguir = Console.ReadLine();
                    }
                        else
                        {
                        Console.WriteLine("Game Over");
                        seguir = "n";
                    }
                }
                    else
                    {
                        Console.WriteLine("Win");
                    }
                }
                Console.WriteLine("Gracias por participar");

            }
        }
    }
    

