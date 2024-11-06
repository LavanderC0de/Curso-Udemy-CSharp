using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2__Calcular_numeros_primos_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int numero, divisor, numDivisores = 0;

            //Bucle exterior, se encarga de recorrer los numeros del 2 al 100
            for(numero = 2; numero <= 100; numero++)
            {
                for(divisor = 1; divisor <= numero; divisor++)
                {
                    if(numero % divisor == 0)
                    {
                        numDivisores += 1;
                    }
                }

                //Verificamos que el numero de divisores sea igual a 2
                if(numDivisores<=2)
                {
                    Console.WriteLine(numero);
                }

                //Reiniciamos el conteo del numero de divisores
                numDivisores = 0;
            }
        }
    }
}
