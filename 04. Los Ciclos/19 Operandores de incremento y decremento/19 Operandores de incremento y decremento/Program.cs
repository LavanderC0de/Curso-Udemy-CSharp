using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Operandores_de_incremento_y_decremento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i; //Operando

            i = 10;

            Console.WriteLine("Valor inicial del operando: {0}", i);

            //Incremento con sufijo e imprimimos
            Console.WriteLine("Valor con incremento incluido: {0}", i++);

                //Ya no incrementamos, solo imprimimos
                Console.Write(i);

            int n = 20;
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Valor inicial del operando: {0}", n);

            //Decremento con sufijo e imprimimos
            Console.WriteLine("Valor con decremento incluido: {0}", n--);

            //Ya no decrementamos, solo imprimimos
            Console.Write(n);
        }
    }
}
