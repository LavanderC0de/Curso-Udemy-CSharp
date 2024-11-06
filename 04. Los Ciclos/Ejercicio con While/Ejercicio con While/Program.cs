using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_con_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contraseña1, contraseña2 = "";

            Console.Write("Escribe tu contraseña: ");
            contraseña1 = Console.ReadLine();

            while(contraseña1 != contraseña2)
            {
                Console.Write("Confirma tu contraseña: ");
                contraseña2 = Console.ReadLine();
            }

            Console.WriteLine("!Contraseña guardada!");
        }
    }
}
