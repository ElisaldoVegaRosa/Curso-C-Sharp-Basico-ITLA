using System;

class FormulaCuadratica
{
    static void Main()
    {
        Console.WriteLine("Resolución de ecuación cuadrática: x = (-b ± √(b² - 4ac)) / (2a)");

        Console.Write("Ingrese el valor de a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double discriminante = b * b - 4 * a * c;

        if (discriminante < 0)
        {
            Console.WriteLine("La ecuación no tiene soluciones reales.");
        }
        else if (discriminante == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"La solución única es: x = {x}");
        }
        else
        {
            double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
            Console.WriteLine($"Las soluciones son: x1 = {x1}, x2 = {x2}");
        }
    }
}