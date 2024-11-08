using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_sin_parametro_ni_tipo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int opcion;
            decimal r; //Almacena el valor devuelto de Restar
            decimal num1Ar, num2Ar;  //Argumentos para enviar una copia de su valor a los metodos

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");

                //pedimos una opcion
                Console.Write("Escoge una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            while ((opcion < 1) || (opcion > 4));

            //Hacer la operacion segun la opcion escogida
            switch (opcion)
            {
                case 1:
                    Sumar();
                    break;
                case 2:
                    r = Restar(); //Asignamos a "r" el valor devuelto por return

                    //Mostramos el resultado, con la informacion que contiene "r"
                    Console.WriteLine("El resultado de la resta es: {0}", r);
                    break;
                case 3:
                    //Pedimos el valor de ambs numeros
                    Console.Write("Ingresa el primer numero: ");
                    num1Ar = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("Ingresa el segundo numero: ");
                    num2Ar = Convert.ToDecimal(Console.ReadLine());

                    //Invocamos el metodo
                    Multiplicar(num1Ar, num2Ar);
;                    break;
                case 4:
                    //Pedimos el valor de ambs numeros
                    Console.Write("Ingresa el primer numero: ");
                    num1Ar = Convert.ToDecimal(Console.ReadLine());

                    Console.Write("Ingresa el segundo numero: ");
                    num2Ar = Convert.ToDecimal(Console.ReadLine());

                    r = Dividir(num1Ar, num2Ar);

                    //Mostramos el resultado, con la informacion que contiene "r"
                    Console.WriteLine("El resultado de la division es: {0}", r);
                    break;
            }

        } //Cierre de main

        // (modificador)  (tipo)  (identificador)  (parametros)
        static void Sumar ()
        {
            //Variables del metodo Sumar
            decimal num1, num2, resultado;

            //Pedimos el valor de ambs numeros
            Console.Write("Ingresa el primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingresa el segundo numero: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            //Operacion
            resultado = num1 + num2;

            //Mostramos el resultado
            Console.WriteLine("{0] + {1] = {2]", num1, num2, resultado);
        }

        // (modificador)  (tipo)  (identificador)  (parametros)
        static decimal Restar()
        {
            //Variables del metodo Sumar
            decimal num1, num2, resultado;

            //Pedimos el valor de ambs numeros
            Console.Write("Ingresa el primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Ingresa el segundo numero: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            //Operacion
            resultado = num1 - num2;

            //Devolvemos un tipo al autor de llamado
            return resultado;
        }

        // (modificador)  (tipo)  (identificador)  (parametros)
        static void Multiplicar (decimal num1Pa, decimal num2Pa)
        {
            //Variables
            decimal resultado;
            
            //Multiplicacion con los varoles que mandaron los argumentos
            resultado = num1Pa * num2Pa;

            //Mostramos el resultado
            Console.WriteLine("{0] * {1] = {2]", num1Pa, num2Pa, resultado);
        }

        // (modificador)  (tipo)  (identificador)  (parametros)
        static decimal Dividir(decimal num1Pa,decimal num2Pa)
        {
            // Variable
            decimal resultado;

            if(num2Pa != 0)
            {
                //Divison con los valores de los argumentos
                resultado = num1Pa / num2Pa;
            }
            else
            {
                Console.WriteLine("No es posible dividir entre cero");
                resultado = 0;
            }

            return resultado;
        }
    }
}
