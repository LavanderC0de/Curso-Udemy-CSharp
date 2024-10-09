using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2_Multiples_sentencias_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // programa que hace la division de dos numeros

            // Variables
            double dividendo, divisor, resultado;

            // Pedimos el dividendo
            Console.Write("Dame el dividendo: ");
            dividendo = Convert.ToDouble(Console.ReadLine());

            // Pedimos el divisor
            Console.Write("Dame el divisor: ");
            divisor = Convert.ToDouble(Console.ReadLine());

            if (divisor != 0)
            {
                resultado = dividendo / divisor;
                Console.WriteLine ("{0} / {1} = {2}", dividendo, divisor, resultado);
            }
        }
    }
}
