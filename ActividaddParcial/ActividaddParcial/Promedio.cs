using System;
namespace ActividaddParcial
{
    internal class Calcular
    {
        private double total;

        public double AgregarValor(int valor){
            total+=valor;
            return total;
        }
         public double CalcularPromedio(int cont){

            if (cont == 0)
            {
                Console.WriteLine("no se puede calcular sin ingresos: el promedio es 0");
                return 0;
            }

            else
            {

                double promedio = (total / cont);
                return promedio;
            }  

        }

    }
}
