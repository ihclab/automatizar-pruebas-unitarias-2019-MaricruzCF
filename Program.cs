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
                    casosPrueba[i,j] = pruebas[j]; // estamos ciclando en el vector pequeño, de 4 elementos
                }
            }
        }
    }
}
