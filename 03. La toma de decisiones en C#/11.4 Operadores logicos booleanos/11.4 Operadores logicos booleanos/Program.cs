using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._4_Operadores_logicos_booleanos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            float energia;
            bool propulsorizquierdo, propulsorderecho;

            Console.WriteLine("Ingrese el nivel de energia: ");
            energia = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("¿El propulsor derecho esta en buen estado? (true/false):  ");
            propulsorderecho = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("¿El propulsor izquierdo esta en buen estado? (true/false):  ");
            propulsorizquierdo = Convert.ToBoolean(Console.ReadLine());

            if (((((propulsorderecho) && (propulsorizquierdo)) == true) && (energia >= 75)) || ((((propulsorderecho) || (propulsorizquierdo)) == true) && (energia == 100)))
            {
                Console.WriteLine("Puedes despegar");
            }
            else 
            {
                Console.WriteLine("No puedes despegar");
            }
        }
    }
}
