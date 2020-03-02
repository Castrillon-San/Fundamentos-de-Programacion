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
            int cartas = 0, total = 0, turnos = 0, jugador = 0, ganador = 0, max = 0, maxDos = 0, minDiferencia = 200, diferencia = 200;
            string seguir = "";
            int cartaUno = 0;
            int cartaDos = 0;
            Console.WriteLine("Escriba el numero de jugadores");
            int n = int.Parse(Console.ReadLine());
            int[] puntajes = new int[n];
            string[] nombres = new string[n];

            while (turnos < n)
            {
                Console.WriteLine("Bienvenido jugador " + (turnos + 1));
                Console.WriteLine("ingrese su nombre ");
                nombres[turnos] = Console.ReadLine();
                cartaUno = aleatorio.Next(1, 11);
                cartaDos = aleatorio.Next(1, 11);
                total = (cartaUno + cartaDos);

                Console.WriteLine("el valor de la carta Uno es: " + cartaUno + " y la carta Dos: " + cartaDos);
                Console.WriteLine("el total es: " + total);


                Console.WriteLine("¿nueva carta? (s/n)");
                seguir = Console.ReadLine();

                while (seguir == "s" && total < 21)
                {
                    cartas = aleatorio.Next(1, 11);
                    total += cartas;
                    Console.WriteLine("su nueva carta es: " + cartas);
                    Console.WriteLine("su nuevo total es:" + total);

                    if (total <= 21)
                    {
                        Console.WriteLine("¿nueva carta? (s/n)");
                        seguir = Console.ReadLine();
                    }
                    else Console.WriteLine("Estas eliminado no puedes continuar");

                }
                Console.WriteLine("el total de las cartas es: " + total);
                Console.WriteLine("gracias por participar");
                puntajes[turnos] = total;
                turnos++;
                for (int j = 0; j < n; j++)
                {
                    for (int i = 0; i < n - 1; i++)
                    {
                        if (puntajes[i] > puntajes[i + 1])
                        {
                            int temp = puntajes[i];
                            puntajes[i] = puntajes[i + 1];
                            puntajes[i + 1] = temp;

                            string temp2 = nombres[i];
                            nombres[i] = nombres[i + 1];
                            nombres[i + 1] = temp2;

                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("El puntaje del jugador " + nombres[i] + " es de: " + puntajes[i]);
                }
            }
        }
    }
}
