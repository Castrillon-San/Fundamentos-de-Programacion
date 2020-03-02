using System;

namespace TareaArreglos2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random aleatorio = new Random();

            int n = 0, carta = 0, total = 0, maximoTotal = 0, diferencia = 0, minimo = 200, segundoGanador = 0, p = 0;
            
            string continuar = "s", nombre = "", nombreGanador = "";
            bool perder = true;

            Console.WriteLine("Ingrese el numero de jugadores (minimo 2 - maximo 5)");
            n = int.Parse(Console.ReadLine());
            p = n;
            int[] puntaje = new int[p];
            //Ciclo Validacion Jugadores
            while (2 > n || n > 5)
            {
                Console.WriteLine("Error, Ingrese el numero de jugadores (minimo 2 - maximo 5)");
                n = int.Parse(Console.ReadLine());
            }
            //Ciclo Jugadores
            while (n > 0)
            {
                n--;
                p--;
                Console.WriteLine("Bienvenido a BlackJack, Jugador: " + (n + 1));
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
                    if (total > 21) {
                        Console.WriteLine("Fuiste Eliminado");
                        perder = false;
                        }
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
                    if ((total > maximoTotal) && perder == true) { 
                        maximoTotal = total; 
                    nombreGanador = nombre;
                    }
                    else
                    {
                        maximoTotal = 0;
                        nombreGanador = "Nadie Gana";
                    } 
                } 
                //Guardan los puntajes
                 puntaje[p] = total;
                Console.WriteLine("Gracias por jugar");
                total = 0;
                continuar = "s";
                perder = false;
            }
            for (int i = 0; i < puntaje.Length; i++)
            {
                diferencia = maximoTotal - puntaje[i];
                if(diferencia < minimo && diferencia!= 0 && puntaje[i] <= 21)
                {
                    minimo = diferencia;
                    segundoGanador = (i);
                }
                Console.WriteLine("El segundo lugar es de " + i);
            }
            //Resultado Ganador  
            Console.WriteLine("El jugador con el mayor total fue: " + maximoTotal + " y el ganador fue: " + nombreGanador);

        }
    }
}