using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int numero, exponente, i;
            double resultado = 1, resultadoNegativo;

            //Pedimos la base
            Console.Write("ingresa la base: ");
            numero = Convert.ToInt32(Console.ReadLine());

            //Pedimos el exponente
            Console.Write("ingresa el exponente: ");
            exponente = Convert.ToInt32(Console.ReadLine());

            //Validamos el signo del exponente
            if(exponente < 0)
            {
                //Convertimos el exponente a positivo
                exponente *= -1;

                for(i = 1; i <= exponente; i++) 
                {
                    resultado *= numero;
                }

                //Asignamos a resultado negativo
                resultadoNegativo = (1 / resultado);

                //Mostramos el resultado
                Console.WriteLine("{0}^{1} = {2}", numero, exponente, resultadoNegativo);
            }
            else
            {
                for (i = 1; i <= exponente; i++) 
                {
                    resultado *= numero;
                }
                //Mostramos el resultado
                Console.WriteLine("{0}^{1} = {2}", numero, exponente, resultado);
            }
        }
    }
}
