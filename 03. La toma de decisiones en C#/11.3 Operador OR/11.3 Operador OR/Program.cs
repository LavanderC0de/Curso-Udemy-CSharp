using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._3_Operador_OR
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Variables
            float calprepa, calexamen;

            Console.WriteLine("¿Con que nota acabaste tus estudios?: ");
            calprepa = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Ingresa la nota que tuviste en el examen de ingreso: ");
            calexamen = Convert.ToSingle(Console.ReadLine());

            // Condición
            if ((calprepa >=9) || (calexamen >=9.5)) 
            {
                Console.WriteLine("Felicidades tiene la beca!!");

            }
            else
            {
                Console.WriteLine("Lo siento, no eres apto");
            }
        }
    }
}
