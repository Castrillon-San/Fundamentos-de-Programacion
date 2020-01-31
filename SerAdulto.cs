using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ingreso de datos
            Console.WriteLine("Ingrese se Salario mensual");
            double sm = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su tipo de Contrato: Independiente = 1, Dependiente = 2");
            int contrato = int.Parse(Console.ReadLine());
           
            double bc = sm * 0.4;

            if (contrato == 1)
            { Console.WriteLine("Ingrese su clase de Riesgo enumerada de 1 a 5");
                int riesgo = int.Parse(Console.ReadLine());

                
                double pension = bc * 0.16;
                double eps = bc * 0.125;

                if (bc < sm)
                {
                    bc = sm;
                    
                    if( riesgo == 1)
                    {
                        double ARL = bc * 0.00522;
                        double smr = sm - ARL - pension - eps - 135536;
                        double sa = smr * 12;

                        Console.WriteLine("Sus salario real mensual es: " + smr);
                        Console.WriteLine("Sus salario anual con deducciones y bonificaciones es: " + sa);

                    }
                    else if (riesgo == 2)
                    {
                        double ARL = bc * 0.01044;
                        double smr = sm - ARL - pension - eps;
                        double sa = smr * 12;

                        Console.WriteLine("Sus salario real mensual es: " + smr);
                        Console.WriteLine("Sus salario anual con deducciones y bonificaciones es: " + sa);
                    }
                    else if (riesgo == 3)
                    {
                        double ARL = bc * 0.02436;
                        double smr = sm - ARL - pension - eps;
                        double sa = smr * 12;

                        Console.WriteLine("Sus salario real mensual es: " + smr);
                        Console.WriteLine("Sus salario anual con deducciones y bonificaciones es: " + sa);
                    }
                    else if (riesgo == 4)
                    {
                        double ARL = bc * 0.0435;
                        double smr = sm - ARL - pension - eps;
                        double sa = smr * 12;

                        Console.WriteLine("Sus salario real mensual es: " + smr);
                        Console.WriteLine("Sus salario anual con deducciones y bonificaciones es: " + sa);
                    }
                    else
                    {
                        double ARL = bc * 0.0696;
                        double smr = sm - ARL - pension - eps;
                        double sa = smr * 12;

                        Console.WriteLine("Sus salario real mensual es: " + smr);
                        Console.WriteLine("Sus salario anual con deducciones y bonificaciones es: " + sa);
                    }
                }
                else
                {
                    if (riesgo == 1)
                    {
                        double ARL = bc * 0.00522;
                        double smr = sm - ARL - pension - eps - 135536;
                        double sa = smr * 12;

                        Console.WriteLine("Sus salario real mensual es: " + smr);
                        Console.WriteLine("Sus salario anual con deducciones y bonificaciones es: " + sa);

                    }
                    else if (riesgo == 2)
                    {
                        double ARL = bc * 0.01044;
                        double smr = sm - ARL - pension - eps;
                        double sa = smr * 12;

                        Console.WriteLine("Sus salario real mensual es: " + smr);
                        Console.WriteLine("Sus salario anual con deducciones y bonificaciones es: " + sa);
                    }
                    else if (riesgo == 3)
                    {
                        double ARL = bc * 0.02436;
                        double smr = sm - ARL - pension - eps;
                        double sa = smr * 12;

                        Console.WriteLine("Sus salario real mensual es: " + smr);
                        Console.WriteLine("Sus salario anual con deducciones y bonificaciones es: " + sa);
                    }
                    else if (riesgo == 4)
                    {
                        double ARL = bc * 0.0435;
                        double smr = sm - ARL - pension - eps;
                        double sa = smr * 12;

                        Console.WriteLine("Sus salario real mensual es: " + smr);
                        Console.WriteLine("Sus salario anual con deducciones y bonificaciones es: " + sa);
                    }
                    else
                    {
                        double ARL = bc * 0.0696;
                        double smr = sm - ARL - pension - eps;
                        double sa = smr * 12;

                        Console.WriteLine("Sus salario real mensual es: " + smr);
                        Console.WriteLine("Sus salario anual con deducciones y bonificaciones es: " + sa);
                    }
                
                }

            }
            else
            {
                double pension = bc * 0.04;
                double eps = bc * 0.04;
                double smr = sm - pension - eps;
                double sa = smr * 12 + sm;
                Console.WriteLine("Sus salario real mensual es: " + smr);
                Console.WriteLine("Sus salario anual con deducciones y bonificaciones es: " + sa);
            }
        }
    }
}
