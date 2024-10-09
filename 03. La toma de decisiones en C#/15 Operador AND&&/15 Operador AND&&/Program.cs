using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Operador_AND__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte edad;
            bool licencia;

            Console.Write("¿Que edad tienes: ");
            edad = Convert.ToByte(Console.ReadLine());

            Console.Write("¿Tienes carnet de conducir: ");
            licencia = Convert.ToBoolean(Console.ReadLine());

         if (edad>=18 && licencia == true)
            {
                Console.WriteLine("Puedes conducir");
            }
         else
            {
                Console.WriteLine("No puedes conducir");
            }
        }
    }
}