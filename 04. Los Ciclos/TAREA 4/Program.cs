using System;

/* Hacer un programa que calcule la potencia, ya sea negativa o positiva de cualquier exponente.
Hacer un programa que calcule los números primos que existen entre el 1 y el 100*/

namespace CalculadoraPotenciasYPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            bool opcionValida = false;

            while (!opcionValida)
            {
                Console.Clear();
                Console.WriteLine("Este programa tiene dos opciones:");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("1. Calcular la potencia de un número.");
                Console.WriteLine("2. Mostrar los números primos entre 1 y 100.");
                Console.WriteLine("------------------------------------------------");
                Console.Write("Elige una opción (1 o 2): ");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        CalcularPotencia();
                        opcionValida = true;
                        break;
                    case "2":
                        Console.Clear();
                        MostrarPrimos();
                        opcionValida = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Esta opción no es válida porque no has seleccionado un número entre 1 y 2.");
                        Console.WriteLine("Pulse cualquier tecla para volver a intentarlo...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void CalcularPotencia()
        {
            Console.WriteLine("EJERCICIO 1: Calcular la potencia de un número.");
            Console.WriteLine("------------------------------------------------");

            Console.Write("Introduce la base: ");
            double numeroBase = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce el exponente: ");
            int exponente = Convert.ToInt32(Console.ReadLine());

            double resultado = 1;

            if (exponente == 0)
            {
                resultado = 1;
            }
            else if (exponente > 0)
            {
                for (int i = 1; i <= exponente; i++)
                {
                    resultado *= numeroBase;
                }
            }
            else
            {
                for (int i = 1; i <= -exponente; i++)
                {
                    resultado *= numeroBase;
                }
                resultado = 1 / resultado;
            }

            Console.WriteLine($"Resultado: {resultado}");
        }

        static void MostrarPrimos()
        {
            Console.WriteLine("EJERCICIO 2: Mostrar los números primos entre 1 y 100.");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Los números primos entre el 1 y el 100 son: ");

            for (int num = 2; num <= 100; num++)
            {
                bool esPrimo = true;

                for (int divisor = 2; divisor <= Math.Sqrt(num); divisor++)
                {
                    if (num % divisor == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                {
                    Console.Write(num + " ");
                }
            }

        }
    }
}
