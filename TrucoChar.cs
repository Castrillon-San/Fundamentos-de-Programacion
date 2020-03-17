using System;

namespace ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = {"Natalia", "Samara", "Ronny"};

            for(int i = 0; i < nombres.Length; i++)
            {
                string nombre = nombres[i];
                for(int j = 0; j < nombre.Length; j++)
                {
                    char l = nombre[j];
                    Console.WriteLine(l);
                }
            }
            
        }
    }
}
