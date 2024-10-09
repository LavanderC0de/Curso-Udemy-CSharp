using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Operador_Negacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool bateria;

            Console.Write("¿Hay Batería? true/false: ");
            bateria = Convert.ToBoolean(Console.ReadLine());

            if (!(bateria ==true))
            {
                Console.WriteLine("Conecta el telefono");
            }
            else
            {
                Console.WriteLine("No es necesario conectar el telefono");
            }
        }
    }
}
