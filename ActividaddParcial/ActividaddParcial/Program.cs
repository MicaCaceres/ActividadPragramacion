using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividaddParcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcular numC = new Calcular();
            {

            }

             void Menu();
            {
                int opcion = 0; int valor = 0;
                Console.WriteLine("1-Ingresar valor");
                Console.WriteLine("2-Calcular Promedio");
                Console.WriteLine("3-Salir");
                opcion = Convert.ToInt32(Console.ReadLine());


                do
                {
                    switch (opcion)
                    {
                        case 1:Console.WriteLine("Ingrese valor a agregar");
                            valor = Convert.ToInt32(Console.ReadLine());
                            numC.AgregarValor(valor);
                            break;
                        case 2:
                            
                            Console.WriteLine(numC.CalcularPromedio);
                                break;
                        default:
                            Console.WriteLine("Se cerrara el programa");

                    }

                } while (opcion > 0 && opcion < 3);
            }
        }
    }
}
