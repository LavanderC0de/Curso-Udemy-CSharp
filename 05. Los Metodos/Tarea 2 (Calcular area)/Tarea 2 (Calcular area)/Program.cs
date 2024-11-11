using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2__Calcular_area_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double radioAr, baseAr, alturaAr, ladoAr, area;
            byte opcion;

            //mostramos las opciones
            Console.WriteLine("1. Circulo");
            Console.WriteLine("2. Triangulo");
            Console.WriteLine("3. Cuadrado");

            //Preguntamos
            Console.Write("Escoge una opcion y claculare su area: ");
            opcion = Convert.ToByte(Console.ReadLine());    

            switch (opcion)
            {
                case 1:
                    Console.Write("Dame el valor del radio de tu circulo: ");
                    radioAr = Convert.ToDouble(Console.ReadLine());

                    //Invocamos al metodo
                    area = Circulo(radioAr);

                    //Mostramos el resultado
                    Console.WriteLine("El area es: {0}", area);
                    break;
                case 2:
                    //Pedimos los valores de base y altura
                    Console.Write("Dame el valor de la base de tu triangulo: ");
                    baseAr = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Dame el valor de la altura de tu triangulo: ");
                    alturaAr = Convert.ToDouble(Console.ReadLine());

                    //Invocamos al metodo
                    area = Triangulo(baseAr, alturaAr);

                    //Mostramos el resultado
                    Console.WriteLine("El area es: {0}", area);
                    break;
                case 3:
                    Console.Write("Dame el valor de uno de los lados de tu cuadrado: ");
                    ladoAr = Convert.ToDouble(Console.ReadLine());

                    area = Cuadrado(ladoAr);

                    //Mostramos el resultado
                    Console.WriteLine("El area es: {0}", area);
                    break;

            }

        }

        //Metodo que calcula el area de un circulo
        static double Circulo(double radioPa)
        {
            double area;

            //calcula el area
            area = Math.PI * (radioPa * radioPa);

            //Regresamos el valor de area
            return area;

        }

        //Metodo que calcula el area de un triangulo
        static double Triangulo(double basePa, double alturaPa)
        {
            double area;

            //calcula el area
            area = (basePa * alturaPa) / 2;   

            //Regresamos el valor de area
            return area;

        }

        //Metodo que calcula el area de un cuadrado
        static double Cuadrado(double ladoPa)
        {
            double area;

            //calcula el area
            area = ladoPa * ladoPa;

            //Regresamos el valor de area
            return area;

        }
    }
}
