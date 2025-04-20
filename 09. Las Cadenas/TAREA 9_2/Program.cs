// Programa que pide la fecha de nacimiento y muestra el día de la semana
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Programa para saber el día de la semana de tu nacimiento");
        Console.WriteLine("--------------------------------------------------------");
        
        // Solicitar la fecha de nacimiento al usuario
        Console.Write("Por favor, introduce tu fecha de nacimiento (formato DD/MM/AAAA): ");
        string fechaTexto = Console.ReadLine();
        
        try
        {
            // Convertir la cadena a un objeto DateTime
            DateTime fechaNacimiento = DateTime.Parse(fechaTexto);
            
            // Obtener el día de la semana
            string diaSemana = fechaNacimiento.ToString("dddd");
            
            // Mostrar el resultado
            Console.WriteLine($"\nNaciste un {diaSemana}.");
        }
        catch (FormatException)
        {
            Console.WriteLine("\nError: El formato de fecha introducido no es válido.");
            Console.WriteLine("Por favor, utiliza el formato DD/MM/AAAA (ejemplo: 15/06/1990).");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError inesperado: {ex.Message}");
        }
        
        // Esperar a que el usuario presione una tecla para cerrar
        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
