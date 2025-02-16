using System;
using System.Collections.Generic;

class Program
{
    static List<decimal> gastos = new List<decimal>(); // Lista para almacenar los gastos

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n--- App Bancaria ---");
            Console.WriteLine("1. Ingresar un gasto");
            Console.WriteLine("2. Mostrar todos los gastos (último primero)");
            Console.WriteLine("3. Calcular total de gastos");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    IngresarGasto();
                    break;
                case "2":
                    MostrarGastos();
                    break;
                case "3":
                    CalcularTotalGastos();
                    break;
                case "4":
                    Console.WriteLine("Saliendo de la aplicación...");
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    break;
            }
        }
    }

    static void IngresarGasto()
    {
        Console.Write("Ingresa el monto del gasto: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal monto) && monto > 0)
        {
            gastos.Add(monto);
            Console.WriteLine($"Gasto de {monto:C} agregado correctamente.");
        }
        else
        {
            Console.WriteLine("Monto inválido. Debe ser un número positivo.");
        }
    }

    static void MostrarGastos()
    {
        if (gastos.Count == 0)
        {
            Console.WriteLine("No hay gastos registrados.");
        }
        else
        {
            Console.WriteLine("Lista de gastos (último primero):");
            foreach (var gasto in gastos.AsReadOnly().AsEnumerable().Reverse())
            {
                Console.WriteLine($"- {gasto:C}");
            }
        }
    }

    static void CalcularTotalGastos()
    {
        if (gastos.Count == 0)
        {
            Console.WriteLine("No hay gastos registrados.");
        }
        else
        {
            decimal total = 0;
            foreach (var gasto in gastos)
            {
                total += gasto;
            }
            Console.WriteLine($"El total de gastos es: {total:C}");
        }
    }
}