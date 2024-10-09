using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._3_TAREA_CLASE_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que le diga al usuario el precio que debe de pagar por el servicio estacionamiento de un centro comercial con la base en el tiempo que ha permanecido ahí, los primeros 60 munitos: $5.00, las primeras 2 horas $15.00 y de 2 horas en adelante: $40.00

            float minutos;

            Console.Write("Ingresa el tiempoque estuviste en el estacionamiento (en minutos) = ");
            minutos = Convert.ToSingle(Console.ReadLine());

            if ((minutos >= 0) && (minutos <= 60))
            {
                Console.WriteLine("Paga $5.00 por favor");
            }
            else 
            {
                if (minutos > 60 && minutos <= 120)
                {
                    Console.WriteLine("Paga $15.00");
                }
                else 
                {
                    Console.WriteLine("Paga $4.00");
                }
            }
        }
    }
}
