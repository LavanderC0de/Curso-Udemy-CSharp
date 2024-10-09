using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedir un numero al usuario y determinar si este es positivo o negativo

            // Variables
            double numero;

            // Pedimos el numero a evaluar
            Console.Write("Dame un numero: ");
            numero = Convert.ToDouble(Console.ReadLine());

            //Usamos un condicional "if" para saber si el numero es mayor que cero

            if (numero > 0)

            {
                //Se ejecuta en caso de que la expresion se evalue como true
                Console.Write("El numero es positivo ");
            }

            //Usamos un condicional "if" para saber si el numero es menor que cero

            if (numero < 0)

            {
                //Se ejecuta en caso de que la expresion se evalue como true
                Console.Write("El numero es negativo ");
            }
        }
    }
}
