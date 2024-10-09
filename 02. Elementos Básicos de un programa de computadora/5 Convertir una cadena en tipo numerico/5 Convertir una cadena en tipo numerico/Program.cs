using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Convertir_una_cadena_en_tipo_numerico
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = 5, num2, resultado;

            // Preguntamos al usuario el numero
            Console.Write("Dame un numero para sumarlo: ");

            num2 = Int32.Parse(Console.ReadLine());

            resultado = num1 + num2;

            // Mostramos el resultado
            Console.WriteLine("El numero de la suma es {0}", resultado);


        }
    }
}
