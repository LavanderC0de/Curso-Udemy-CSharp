using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables de bucle (o de control)

            int i;

            for(i = 1, Console.WriteLine("Valor inicial de la veriable: {0}",i) ;  i <= 10; i++)                               //inicializador ; condicion ; iterador
            {
                Console.WriteLine(i);
            }
        }
    }
}
