using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce la base: ");
        double baseNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el exponente: ");
        int exponent = Convert.ToInt32(Console.ReadLine());

        double result = 1;

        if (exponent == 0)
        {
            result = 1;
        }
        else if (exponent > 0)
        {
            for (int i = 1; i <= exponent; i++)
            {
                result *= baseNumber;
            }
        }
        else
        {
            for (int i = 1; i <= -exponent; i++)
            {
                result *= baseNumber;
            }
            result = 1 / result;
        }

        Console.WriteLine($"Resultado: {result}");
    }
}