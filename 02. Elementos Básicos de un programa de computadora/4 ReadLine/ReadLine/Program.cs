using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nombre;

            // Preguntamos el nombre del ususario
            Console.Write("¿Como te llamas?: ");
            nombre = Console.ReadLine();

            // Saludamos al usuario
            Console.WriteLine("Hola {0}, un placer", nombre);
        }
    }
}
