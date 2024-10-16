using System;
using System.Runtime.ConstrainedExecution;

/*Hacer un programa que le pida al usuario un número del 1 al 12
y escriba el nombre del mes que corresponde ese número en el calendario. Agregar un case default.

Hacer un programa que le pida al usuario un número y decirle si éste es par o impar.

Hacer un programa que le diga al usuario el precio que debe pagar por el servicio de estacionamiento de un centro comercial
con base en el tiempo que ha permanecido ahí, 
los primeros 60 minutos: $5.00, las primeras 2 horas $15.00 y de 2 horas en adelante: $40.00*/

namespace tarea3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("En este apartado existen 3 tareas.");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("1. Comprobar mes según número.");
            Console.WriteLine("2. Comprobar si un número es par o impar.");
            Console.WriteLine("3. Calcular el precio del estacionamiento.");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.Write("Inserta un número del 1 al 3 para elegir qué tarea visualizar:");

            string numerotarea = Console.ReadLine();
            Console.Clear();

            switch (numerotarea)
            {
                case "1":
                    Tarea1();
                    break;
                case "2":
                    Tarea2();
                    break;
                case "3":
                    Tarea3();
                    break;
            }
        }
        static void Tarea1()
        {
            Console.WriteLine("EJECUTANDO EL EJERCICIO 1: Mostrar el mes según el número.");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Inserte un numero de mes entre el 1 y el 12");
            byte numeroMes = Convert.ToByte(Console.ReadLine());

            switch(numeroMes)
            {
                case 1:
                    Console.WriteLine("El numero insertado corresponde a Enero");
                    break;
                case 2:
                    Console.WriteLine("El numero insertado corresponde a Febrero");
                    break;
                case 3:
                    Console.WriteLine("El numero insertado corresponde a Marzo");
                    break;
                case 4:
                    Console.WriteLine("El numero insertado corresponde a Abril");
                    break;
                case 5:
                    Console.WriteLine("El numero insertado corresponde a Mayo");
                    break;
                case 6:
                    Console.WriteLine("El numero insertado corresponde a Junio");
                    break;
                case 7:
                    Console.WriteLine("El numero insertado corresponde a Julio");
                    break;
                case 8:
                    Console.WriteLine("El numero insertado corresponde a Agosto");
                    break;
                case 9:
                    Console.WriteLine("El numero insertado corresponde a Septiembre");
                    break;
                case 10:
                    Console.WriteLine("El numero insertado corresponde a Octubre");
                    break;
                case 11:
                    Console.WriteLine("El numero insertado corresponde a Noviembre");
                    break;
                case 12:
                    Console.WriteLine("El numero insertado corresponde a Diciembre");
                    break;
                default: Console.WriteLine("Inserte un valor entre el 1 y el 12");
                    break;
            }
        }
        static void Tarea2()
        {
            Console.WriteLine("EJECUTANDO EJERCICIO 2: Verificar si un número es par o impar.");
            Console.WriteLine("-------------------------------------------------------------");
            Console.Write("Inserta un número para verificar si es par o impar: ");

            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)  // Verifica si el número es divisible entre 2
            {
                Console.WriteLine("El número " + numero + " es par.");
            }
            else
            {
                Console.WriteLine("El número " + numero + " es impar.");
            }
        }
        static void Tarea3()
        {
            Console.WriteLine("EJECUTANDO EL EJERCICIO 3: Calcular el precio del estacionamiento.");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.Write("Inserta el tiempo (en minutos) que has estado estacionado: ");

            int minutos = Convert.ToInt32(Console.ReadLine());

            if (minutos <= 60)
            {
                Console.WriteLine("El precio del estacionamiento es de $5.00");
            }
            else if (minutos <= 120)
            {
                Console.WriteLine("El precio del estacionamiento es de $15.00");
            }
            else
            {
                Console.WriteLine("El precio del estacionamiento es de $40.00");
            }
        }
    }         
}
