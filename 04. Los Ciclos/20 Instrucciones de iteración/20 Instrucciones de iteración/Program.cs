using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Instrucciones_de_iteración
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            double calif1, calif2, calif3, promedio;

            // HAcemos la primera peticion
            Console.Write("Dame la calificacion del primer alumno: ");
            calif1 = Convert.ToDouble(Console.ReadLine());

            // HAcemos la segunda peticion
            Console.Write("Dame la calificacion del segundo alumno: ");
            calif2 = Convert.ToDouble(Console.ReadLine());

            // HAcemos la tercera peticion
            Console.Write("Dame la calificacion del tercer alumno: ");
            calif3 = Convert.ToDouble(Console.ReadLine());

            // Calculamos el promedio
            promedio = (calif1 + calif2 + calif3) / 3;

            // Mostramos el promedio
      
        }
    }
}
