using System;
namespace ActividaddParcial
{
    internal class Calcular
    {
        private double total;
        int cont;

        public void AgregarValor(double valor){
            total+=valor;
            cont++;
        }
         public double CalcularPromedio(){


            double  promedio=0;
            if (cont > 0) 
            { 
                promedio = (total / cont);
            }
                
                return promedio;
            

        }

    }
}
