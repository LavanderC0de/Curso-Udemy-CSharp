using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3_GRADOS_CENTIGRADOS_A_FAHRENHEIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que transforme de grados Centigrados a grados Fahrenheit

            // Variables
            float gradosC, gradosF;

            // Pedimos los ºC
            Console.Write("Dame los ºC: ");
            gradosC = Convert.ToSingle(Console.ReadLine());

            // Convertimos los ºC a ºF
            gradosF = (gradosC * 1.8f) + 32;

            // Mostrar el resultado
            Console.WriteLine("{0} ºC = {1} ºF", gradosC, gradosF);
        }
    }
}
