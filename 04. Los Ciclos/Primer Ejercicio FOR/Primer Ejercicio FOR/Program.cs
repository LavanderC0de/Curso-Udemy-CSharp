using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Ejercicio_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asignacion compuesta (x -= 5) == (x = x - 5)
            // (acumulador =acumulador + variable) == (acumulador += variable)

            // Variables
            byte i, numAlumnos;
            double calificacion, sumaCalif = 0, promedio;

            Console.Write("Ingresa el numero de alumnos: ");
            numAlumnos = Convert.ToByte(Console.ReadLine());

            for (i = 1; i <= numAlumnos; i++)
            {
                Console.Write("Ingresa la calificacion: ");
                calificacion = Convert.ToDouble(Console.ReadLine());

                sumaCalif += calificacion;
            }

            // Calculamos el promedio
            promedio = sumaCalif / numAlumnos;

            //mostramos el promedio
            Console.WriteLine("El promedio es: {0}", promedio);
        }
    }
}
