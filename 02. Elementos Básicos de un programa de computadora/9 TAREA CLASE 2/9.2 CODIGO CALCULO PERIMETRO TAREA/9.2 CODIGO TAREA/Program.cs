using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2_CODIGO_TAREA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que calcule el perimetro de cualquier poligono regular

            // Variables
            int numerolados;
            double tamañolado, perímetro;

            // Pedimos el numero de lados
            Console.Write("Dame el numero de lados: ");
            numerolados = Convert.ToInt32(Console.ReadLine());

            // Pedimos la medida de uno de los lados
            Console.Write("Dame el tamaño de uno de los lados: ");
            tamañolado = Convert.ToDouble(Console.ReadLine());


            // Calculo de perimetro
            perímetro = numerolados * tamañolado;

            // Mostramos el resultado
            Console.WriteLine("El perímetro es: {0}", perímetro);
        }
    }
}
