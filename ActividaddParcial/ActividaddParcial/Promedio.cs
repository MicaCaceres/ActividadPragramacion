using System;
namespace ActividaddParcial
{
    internal class Promedio {


        private double[] valores;
        int cont;

        //private double  total;
        // int cont;
        public Promedio() {
            valores = new double[100];
            cont = 0;
        }

        public void AgregarValor(double valor) {
            //total+=valor;
            //cont++;
            valores[cont++] = valor;
        }
        public double CalcularPromedio() {

            double total=0;
            for(int n = 0; n < cont; cont++) {
                total += valores[n];
            }


            double  promedio=0;
            if(cont > 0) {
                promedio = (total / cont);
            }

            return promedio;


        }
    }
       
}
