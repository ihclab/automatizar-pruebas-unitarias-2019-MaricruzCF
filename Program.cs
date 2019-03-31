using System;

namespace AutomatizarPruebasUnitarias
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] casos = File.ReadAllLines("CasosPrueba.txt");
            string[,] casosPrueba = new string[casos.Length, 4];
           
            for(int i =0; i < casos.Length; i++)
            {
                string[] pruebas = casos[i].Split(':'); // esto devulve un vector de 4
                for(int j = 0; j < 4; j++) // este ciclo es el que llega hasta menor a 4
                {
                    casosPrueba[i,j] = pruebas[j]; //ciclando en el vector pequeño, de 4 elementos
                }
            }

            for(int i =0; i < casos.Length; i++)
            {
                // Donde se almacenaran los valores en su tipo correcto.
                int[] entradas;
                double resultado;

                // El array de entradas como sale del archivo.
                string[] entradasStr = casosPrueba[i, 2].Split(' ');
                entradas = new int[entradasStr.Length];

                //La conversion de cadena a entero para su manipulacion
                for (int j = 0; j < entradasStr.Length; j++)
                {
                    entradas[j] = int.Parse(entradasStr[j]);
                }
                
                //La conversion de cadena a double para su manipulacion
                resultado = double.Parse(casosPrueba[i, 3]);

            }
        }
    }
}
