using System;
using System.IO;

namespace AutomatizarPruebasUnitarias
{
    class Program
    {
        static double truncar(double num)
        {
            return Math.Truncate(num * 10000) / 10000;
        }
        static void Main(string[] args)
        {
            //lee todo el archivo y lo separa por saltos de linea
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

            for(int i =0; i < casos.Length; i++) // Cicla cada caso
            {
                // Donde se almacenaran los valores en su tipo correcto.
                int[] entradas;
                double resultadoEsperado, resultadoObtenido;

                // El array de entradas como sale del archivo.
                string[] entradasStr = casosPrueba[i, 2].Split(' ');
                entradas = new int[entradasStr.Length];

                //La conversion de cadena a entero para su manipulacion
                for (int j = 0; j < entradasStr.Length; j++)
                {
                    entradas[j] = int.Parse(entradasStr[j]);
                }
                
                //La conversion de cadena a double para su manipulacion
                resultadoEsperado = double.Parse(casosPrueba[i, 3]);
                
                //llamar al metodo
                string metodo = casosPrueba[i,1];
                if(metodo == "mediaAritmetica")
                {
                    // Llamar a meetodo de la clase
                    resultadoObtenido = truncar(Medias.mediaAritmetica(entradas));
                }
                else if(metodo == "mediaArmonica")
                {
                    // Llamar a meetodo de la clase
                    resultadoObtenido = truncar(Medias.mediaArmonica(entradas));
                }
                else if(metodo == "mediaGeometrica")
                {
                    // Crer la instancia (objeto) de la clase
                    Medias medias = new Medias(); 
                    // Lamar metodo del objeto
                    resultadoObtenido = truncar(medias.mediaGeometrica(entradas));
                }
                else
                {
                    //Excecion de metodo no existente
                    throw new System.InvalidOperationException("Medida no existente");
                }
                Console.WriteLine(
                    casosPrueba[i, 0] + "   " + (resultadoEsperado == resultadoObtenido ? "Exito" : "*Falla*")
                    + "   " + casosPrueba[i, 1] + " Calculado = " + resultadoObtenido + " T.E: 0.002 ms");
            }
        }
    }
}
