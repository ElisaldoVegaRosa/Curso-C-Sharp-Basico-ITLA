using System;

class Division
{
    static void Main()
    {
        Console.WriteLine("División de dos números");
        Console.Write("Ingrese el primer número (dividendo): ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número (divisor): ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num2 == 0)
        {
            Console.WriteLine("Error: No se puede dividir por cero.");
        }
        else
        {
            double resultado = num1 / num2;
            Console.WriteLine($"El resultado de la división es: {resultado}");
        }
    }
}