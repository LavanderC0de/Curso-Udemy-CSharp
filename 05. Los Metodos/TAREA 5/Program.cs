using System;
using System.Runtime.ConstrainedExecution;

/*Crear un método para transformar de grados a radianes

Crear una aplicación que calcule el área de un círculo, cuadrado o triangulo. 
Le preguntaremos al usuario a qué figura le quiere calcular el área y dependiendo el caso, ejecutará uno de los 3 métodos.*/


namespace TAREA5
{
    class Program
    {
        static void Main(string[] args)
        {
            string numerotarea;
            bool opcionValida = false;

            while (!opcionValida)
            {
                Console.Clear();
                Console.WriteLine("En este apartado existen 2 tareas.");
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("1. Crear un método para transformar de grados a radianes.");
                Console.WriteLine("2. Crear una aplicación que calcule el área de un círculo, cuadrado o triangulo.");
                Console.WriteLine("---------------------------------------------------------------------");
                Console.Write("Inserta un número del 1 o 2 para elegir qué tarea visualizar: ");
                numerotarea = Console.ReadLine();

                if (numerotarea == "1" || numerotarea == "2")
                {
                    opcionValida = true;
                    Console.Clear();

                    switch (numerotarea)
                    {
                        case "1":
                            Apartado1();
                            break;
                        case "2":
                            Apartado2();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, selecciona 1 o 2.");
                    Console.WriteLine("Presiona cualquier tecla para volver a intentarlo...");
                    Console.ReadKey();
                }
            }
        }
        static void Apartado1()
        {
            //Crear un método para transformar de grados a radianes
            double gradosAr, radianes;
            Console.Write("ingresa los grados: ");
            gradosAr = Convert.ToDouble(Console.ReadLine());

            //Invocamos al metodo
            radianes = ConvertirGradosaRadianes(gradosAr);

            //Mostramos el resultado
            Console.WriteLine("{0}º = {1} Radianes", gradosAr, radianes);
        }
        static double ConvertirGradosaRadianes(double gradosPa)
        {
            double radianes;
            radianes = (gradosPa * Math.PI) / 180;
            return radianes;
        }
        static void Apartado2()
        {
            double radioAr, alturaAr, baseAr, ladoAr, area;
            byte figuraElegida;
            Console.WriteLine("Inserta un numero entre el 1 y el 3 para escoger entre:");
            Console.WriteLine("1.Cuadradro");
            Console.WriteLine("2.Circulo");
            Console.WriteLine("3.Triangulo");
            figuraElegida = Convert.ToByte(Console.ReadLine());
            Console.Clear();
            switch (figuraElegida)
            {
                case 1:
                    Console.WriteLine("¿Cuanto mide el lado del cuadrado?");
                    ladoAr = Convert.ToDouble(Console.ReadLine());
                    area = Cuadrado(ladoAr);
                    Console.WriteLine("El area del cuadrado es {0}", area);
                    break;
                case 2:
                    Console.WriteLine("¿Cuanto mide el radio del círculo?");
                    radioAr = Convert.ToDouble(Console.ReadLine());
                    area = Circulo(radioAr);
                    Console.WriteLine("El area del circulo es {0}", area);
                    break;
                case 3:
                    Console.WriteLine("¿Cuanto mide la base del triángulo?");
                    baseAr = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("¿Cuanto mide la altura del triángulo?");
                    alturaAr = Convert.ToDouble(Console.ReadLine());
                    area = Triangulo(baseAr, alturaAr);
                    Console.WriteLine("El area del triangulo es {0}", area);
                    break;

            }
        }
        static double Circulo(double radioPa)
        {
            double area;
            area = Math.PI * radioPa * radioPa;
            return area;
        }
        static double Cuadrado(double ladoPa)
        {
            double area;
            area = ladoPa * ladoPa;
            return area;
        }
        static double Triangulo(double BasePa, double alturaPa)
        {
            double area;
            area = BasePa * alturaPa / 2;
            return area;
        }


    }
}


