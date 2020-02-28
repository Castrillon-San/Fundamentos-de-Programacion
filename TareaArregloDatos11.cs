using System;

namespace ArregloDatos1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] coordsX = { 0, 2, 3, 7 };
            double[] coordsY = { 0, 1, 5, 6 };
            double distancia = 0, maximo = 0;

            double AB = (coordsY[1] - coordsY[0]) / (coordsX[1] - coordsX[0]);
            double BC = (coordsY[2] - coordsY[1]) / (coordsX[2] - coordsX[1]);
            double CD = (coordsY[3] - coordsY[2]) / (coordsX[3] - coordsX[2]);
            double AD = (coordsY[3] - coordsY[0]) / (coordsX[3] - coordsX[0]);
            double AC = (coordsY[2] - coordsY[1]) / (coordsX[2] - coordsX[1]);
            double BD = (coordsY[3] - coordsY[1]) / (coordsX[3] - coordsX[1]);

            bool A = AB == BC, B = BC == CD, C = CD == AD, D = AB == AD, E = AC == AB, F = BD == AD;

            if (A && B && C && D && E && F) Console.WriteLine("Si estan en la misma recta");
            else Console.WriteLine("No estan en la misma recta");

            for (int i = 0; i < 3; i++)
            {
                distancia = Math.Sqrt((Math.Pow((coordsX[i + 1] - coordsX[i]), 2)) + (Math.Pow((coordsY[i + 1] - coordsY[i]), 2)));
                Console.WriteLine("Iteracion " + i + "  " + distancia);
                if (distancia > maximo) maximo = distancia;
            }

            double distanciaAD = Math.Sqrt((Math.Pow((coordsX[3] - coordsX[0]), 2)) + (Math.Pow((coordsY[3] - coordsY[0]), 2)));
            if (distanciaAD > maximo) maximo = distanciaAD;
            double distanciaAC = Math.Sqrt((Math.Pow((coordsX[2] - coordsX[1]), 2)) + (Math.Pow((coordsY[2] - coordsY[1]), 2)));
            if (distanciaAC > maximo) maximo = distanciaAC;
            double distanciaBD = Math.Sqrt((Math.Pow((coordsX[3] - coordsX[1]), 2)) + (Math.Pow((coordsY[3] - coordsY[1]), 2)));
            if (distanciaBD > maximo) maximo = distanciaBD;

            Console.WriteLine("La distancia maxima es de: " + maximo);
        }
    }
}
