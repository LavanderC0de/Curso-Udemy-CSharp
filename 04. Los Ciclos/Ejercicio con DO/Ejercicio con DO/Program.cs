using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_con_DO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            decimal num1, num2, resultado =0M;
            byte opcion;

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");

                //Pedimos una opcion
                Console.Write("Escoge una opcion: ");
                opcion = Convert.ToByte(Console.ReadLine());
            }
            while ((opcion < 1 || (opcion > 4));

            //Pedimos los dos numeros
            Console.Write("Dame el primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Dame el segundo numero: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            //Hacer la operacion segun la opcion escogida
            switch(opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    if(num2 !=0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Divisor no es valido");
                    }
                    break;
            }

            Console.WriteLine("El resultado es: {0}", resultado);
        }

    }
}
