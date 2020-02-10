using System;

namespace TareaSwitch
{
    class SerAdultoSwitch
    {
        static void Main(string[] args)
        {
            //Ingreso de datos

            Console.WriteLine("Ingrese su Salario");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su tipo de Contrato como Dependiente: 1 | Independiente: 2");
            int contrato = int.Parse(Console.ReadLine());
            double arl = 0, pension = 0, eps = 0, prima = 0; 
            double minimo = 877803;
            double bc = 0.4 * salario;
            double deduccion = 0;

            //Base de Cotizacion segun salario
            if (bc < minimo) bc = minimo;

            //Condicionales
            switch (contrato) {
              
                case 2:
                    Console.WriteLine("Ingrese su clase de riesgo de 1 a 5");
                    int cr = int.Parse(Console.ReadLine());
                    eps = 0.125 * bc;
                    pension = 0.16 * bc;
                    
                    switch (cr)
                    {
                        case 1: arl = bc * 0.00522;
                            break;
                        case 2: arl = bc * 0.01044;
                            break;
                        case 3: arl = bc * 0.02436;
                            break;
                        case 4: arl = bc * 0.04350;
                            break;
                        default: arl = bc * 0.069;
                            break;
                    }
                   deduccion = eps + pension + arl;
                    break;

                default: 
                    eps = bc * 0.04;
                    pension = bc * 0.04;
                    prima = salario;
                    deduccion = eps + pension;
                    break;
            }

            //Resultados
            double salarioReal = salario - deduccion;
            double salarioAnual = (salarioReal * 12) + prima;

            Console.WriteLine("Su salario real mensual es de: " + salarioReal);
            Console.WriteLine("Su Salario anual es de: " + salarioAnual);
        }
    }
}
