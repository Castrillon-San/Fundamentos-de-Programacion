using System;

namespace Validacion
{
    class Program
    {
        static void Main(string[] args)
        {

            Random aleatorio = new Random();

            int  n = 0, carta = 0, total = 0, maximoTotal = 0;
            string continuar = "s", nombre = "", nombreGanador = "";

            Console.WriteLine("Ingrese el numero de jugadores (minimo 2 - maximo 5)");
            n = int.Parse(Console.ReadLine());

            //Ciclo Validacion Jugadores
            while ( 2 > n || n > 5 )
            {
                Console.WriteLine("Error, Ingrese el numero de jugadores (minimo 2 - maximo 5)");
                n = int.Parse(Console.ReadLine());
            }
            //Ciclo Jugadores
            while (n > 0) {
                n--;
                Console.WriteLine("Bienvenido a BlackJack, Jugador: " + (n+1) );
                carta = aleatorio.Next(1, 11);
                total += carta;
                Console.WriteLine("Carta 1 = " + carta);
                carta = aleatorio.Next(1, 11);
                Console.WriteLine("Carta 2 = " + carta);
                total += carta;
                Console.WriteLine("Total = " + total);
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();

                Console.WriteLine("Su total inicial por ambas cartas es de: " + total);

                while (continuar == "s" && total < 21)
                {
                    carta = aleatorio.Next(1, 11);
                    Console.WriteLine("Carta = " + carta);
                    total += carta;
                    Console.WriteLine("Total = " + total);
                    if (total > 21) Console.WriteLine("Fuiste Eliminado");
                    else
                    {
                        Console.WriteLine("Total = " + total);
                        Console.WriteLine("Desea continuar? Presione s para sí, n para no");
                        continuar = Console.ReadLine();

                        //Ciclo Validacion Continuar
                        while (continuar != "s" && continuar != "n")
                    {
                        Console.WriteLine("Error, Desea continuar? Presione s para sí, n para no");
                        continuar = Console.ReadLine();
                    }
                    }
                    if (total > maximoTotal) maximoTotal = total; nombreGanador = nombre ;
                }
                Console.WriteLine("Gracias por jugar");
                total = 0;
                continuar = "s";
            } 
            //Resultado Ganador  
            Console.WriteLine("El jugador con el mayor total fue: " + maximoTotal + " y el ganador fue: " + nombreGanador);
        }
    }
}
