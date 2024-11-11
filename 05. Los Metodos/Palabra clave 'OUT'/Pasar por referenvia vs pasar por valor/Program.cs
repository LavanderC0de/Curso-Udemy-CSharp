using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasar_por_referenvia_vs_pasar_por_valor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pasar por valor
            byte numAr;
            string saludoAr;
            int numPrimoAr;

            //Asignamos un valor
            numAr = 10;

            //Mostramos su valor en la consola
            Console.WriteLine(numAr);

            //Invocamos al metodo y mandamos a los argumentos
            Prueba(out numAr, out saludoAr, out numPrimoAr);

            //Despues de que el metodo cambio el valor, volvemos a mostrar el argumento
            Console.WriteLine(numAr);
            Console.WriteLine(saludoAr);
            Console.WriteLine(numPrimoAr);
        }

        static void Prueba(out byte numPa, out string saludoPa, out int numPrimoPa)
        {
            //Modificamos el valor de los parametros
            numPa = 20;
            saludoPa = "Hola a todos";
            numPrimoPa = 7;
        }
    }
}
