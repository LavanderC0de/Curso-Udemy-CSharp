using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double gradosAr, radianes;

            Console.Write("Ingresa los graods: ");
            gradosAr = Convert.ToDouble(Console.ReadLine());

            //Invocamos al metodo
            radianes = GradoRadianes(gradosAr);

            //Mostramos el resultado con el valor devuelto del metodo
            Console.WriteLine("{0}º = {1} Radianes", gradosAr, radianes);
        }

        static double GradoRadianes(double gradosPa)
        {
            double radianes;

            radianes = (gradosPa * Math.PI) / 180;

            return radianes;
        }
        
    }
}
