using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tupla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "David";
            byte edad = 50;
            long numero = 55555;
            int dirPostal = 2578522;

            // (tipo) Identificador = (valor);
            var persona1 = (nombre: "David",edad: 50,numero: 55555,dirPostal: 2578522);

            //Items 

            Console.WriteLine(persona1.nombre);
        }
    }
}
