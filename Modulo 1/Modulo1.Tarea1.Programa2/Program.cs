using System;

class Multiplicacion
{
    static void Main()
    {
        Console.WriteLine("Multiplicación de dos números");
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = num1 * num2;
        Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
    }
}