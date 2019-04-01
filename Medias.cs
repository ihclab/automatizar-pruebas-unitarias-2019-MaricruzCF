using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizarPruebasUnitarias {
    
    class Medias {

        /**
         * Calcula y regresa la media artimética
         */
        public static double mediaAritmetica(params int[] vals) { 
            int suma = 0;
            for(int i= 0; i<vals.Length;i++){
                suma += vals[i];
            }
            return suma / (double) vals.Length;
        }

        /**
         * Calcula y regresa la raíz enésima = x^(1/n)
         */
        private static double raizEnesima(double x, int n) { 
            return Math.Pow(x,1/n);
        }

        /**
         *  Usa raizEnesima para calcular y regresar la media geométrica
         */
        public double mediaGeometrica(params int[] vals) { 
            int multi = 0;
            for(int i = 0;i<vals.Length;i++){
                multi *= vals[i];
            }
            return raizEnesima(multi, vals.Length);
        }

        /**
         * Este método no está implementado.
         */
        public static double mediaArmonica(params int[] vals) {
            double suma =0;
            for(int i = 0; i <vals.Length; i++){
                suma += 1 / vals[i];
            }
            return (double) vals.Length / suma;
         }
    }
}