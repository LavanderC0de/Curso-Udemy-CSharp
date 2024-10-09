using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que determina si eres mayor de edad, con base en tu edad

            //Variables
            byte edad;

            // Pedimos la edad
            Console.Write("¿Que edad tienes? ");
            edad = Convert.ToByte(Console.ReadLine());  

            if (edad >=18)

        {
                // Se ejecuta si la condicion es "true"
                Console.WriteLine("Eres mayor de edad");
            }

            else
            {
                // Se ejecuta si la condicion es "false"
                Console.WriteLine("Eres menor de edad");
            }


        }
    }
}
