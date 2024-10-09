using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string color;
            Console.Write("Mete el color RGB para darte su código:  ");
            color = Console.ReadLine();

            switch(color)
            {
                case "Red":
                case "RED":
                case "red":
                    Console.WriteLine("El código RGB para {0} es: 255, 0, 0", color);
                    break;
                case "Green":
                    Console.WriteLine("El código RGB para {0} es: 0, 255, 0", color);
                    break;
                case "Blue":
                    Console.WriteLine("El código RGB para {0} es: 0, 0, 255", color);
                    break;
                default:
                    Console.WriteLine("No se encontró el código RGB para el color {0}, intenta de nuevo", color);
                    break;

            }
        }
    }
}   
