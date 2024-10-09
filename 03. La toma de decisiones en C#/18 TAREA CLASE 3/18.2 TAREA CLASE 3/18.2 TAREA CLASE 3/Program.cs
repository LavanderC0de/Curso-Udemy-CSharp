using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._2_TAREA_CLASE_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que le pida al usuario un numero y decirle si este es par o impar

            long numero;

            Console.Write("Dame un numero y te dire si es par o impar: ");
            numero = Convert.ToInt64(Console.ReadLine());

            if ((numero % 2) == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
        }
    }
}
