using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Escalera_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Se necesita un programa que realice las 4 operaciones basicas: suma, resta, multiplicacion y division, a partir de dos numeros, la operacion deseada sera elegida por el usuario.

            //Variables
            decimal num1, num2, resultado = 0.0M;
            byte opcion;

            // Mostramos el menu
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Divison");

            // Pedimos que el usuario escoja una opcion
            Console.Write("Escoge una opcion: ");
            opcion = Convert.ToByte(Console.ReadLine());

            // Pedimos el primer numero
            Console.Write("Dame el primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            // Pedimos el segundo numero
            Console.Write("Dame el segundo numero: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            // Suma
            if (opcion == 1)
            {
                resultado = num1 + num2;
            }
            else 
            {
               // Resta
                if (opcion == 2)
                {
                    resultado = num1 - num2;
                }
                else
                {
                    // Multiplicacion
                    if (opcion == 3)
                    {
                        resultado = num1 * num2;
                    }
                    else 
                    {
                        // Division
                        if (opcion == 4)
                        {
                            if (num2 != 0)
                            {
                                resultado = num1 / num2;
                            }
                            else
                            {
                                Console.WriteLine("No es posible dividir entre cero!");
                            }
                        }
                }
            }


            }

            // Mostramos el resultado
            Console.WriteLine("El resultado es {0}", resultado);

        }
    }
}
