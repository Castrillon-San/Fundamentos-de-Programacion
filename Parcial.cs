using System;
using System.Collections.Generic;
using System.Text;

class Parcial {

    string[] names;
    double[] data;
    

    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        int salida = 0 ;
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double suma = 0, promedio = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
            promedio = suma / notas.Length;
        }
        for (int i = 0; i < notas.Length; i++)
        {
            if(notas[i] > (promedio + 0.5))
            {
                salida++;
            }
        }



        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[5];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double promedio = 0, suma = 0, desvi = 0;
        double[] desviaciones = new double[notas.Length];

        for (int i = 0; i < notas.Length; i++)
        {
            for (int j = 0; j < notas.Length - 1; j++)
            {
                if (notas[j] > notas[j + 1])
                {
                    double Tem = notas[j];
                    notas[j] = notas[j + 1];
                    notas[j + 1] = Tem;

                    string tem2 = nombres[j];
                    nombres[j] = nombres[j + 1];
                    nombres[j + 1] = tem2;
                }
            }
        }

        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
            promedio = suma / notas.Length;
        }
        for (int i = 0; i < nombres.Length; i++)
        {
            desvi = Math.Sqrt(Math.Pow((notas[i] - promedio), 2));
            desviaciones[i] = desvi;
        }
        for (int i = 0; i < desviaciones.Length; i++)
        {
            for (int j = 0; j < desviaciones.Length - 1; j++)
            {
                if (desviaciones[j] < desviaciones[j + 1])
                {
                    double Tem = desviaciones[j];
                    desviaciones[j] = desviaciones[j + 1];
                    desviaciones[j + 1] = Tem;

                    string tem2 = nombres[j];
                    nombres[j] = nombres[j + 1];
                    nombres[j + 1] = tem2;
                }
            }
        }
        for (int i = 0; i < 5; i++)
        {
            salida[i] = nombres[i];
        }

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] TercerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        
        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------




        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] CuartoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------




        //- Arriba de esta línea va su código --------
        return salida;
    }

    public List<string> TercerPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double longitud = notas.Length;
        double mitad = longitud / 2;
        double mediana = 0;

        for (int i = 0; i < notas.Length; i++) 
        {
            for (int j = 0; j < notas.Length - i - 1; j++)
            {
                if (notas[j] > notas[j + 1])
                {
                    double Tem = notas[j];
                    notas[j] = notas[j + 1];
                    notas[j + 1] = Tem;

                    string tem2 = nombres[j];
                    nombres[j] = nombres[j + 1];
                    nombres[j + 1] = tem2;
                }
            }
        }

        /*if (longitud % 2 == 0) 
        {
            mediana = (notas[mitad] + notas[mitad]) / 2;
        }
        else 
        {
            mediana = notas[mitad];
        }*/


        //- Arriba de esta línea va su código --------
        return salida;
    }

    public List<string> CuartoPuntoListas() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);
        
        List<string> salida = new List<string>();
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double suma = 0, promedio = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
            promedio = suma / notas.Length;
        }
        for (int i = 0; i < nombres.Length; i++)
        {
            nombres[i] = nombres[i].ToUpper();
        }
        for (int i = 0; i < nombres.Length; i++)
        {
          
            for (int j = 0; j < nombres[i].Length; j++)
            {
                if(nombres[i][j] == 'A' && notas[i] >= promedio)
                {
                    salida.Add(nombres[i]);
                    break;
                }
            }
        }


        //- Arriba de esta línea va su código --------
        return salida;
    }
}


