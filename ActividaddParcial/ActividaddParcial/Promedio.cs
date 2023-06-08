using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividaddParcial
{
    internal class Calcular
    {
        int valor = 0; int cont = 0;
        double total = 0;

        public int AgregarValor(int valor);{
        cont++;
            total+=valor;
            return total;
        }
    public double CalcularPromedio();
    {
        if (cont==0 && total==0){
        Console.WriteLine("no se puede calcular sin ingresos: el promedio es 0");
        else return(total/cont*100)
    }
         
    }

    }
}
