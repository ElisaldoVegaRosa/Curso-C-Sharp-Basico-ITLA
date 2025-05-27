using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        DateTime hoy = DateTime.Now;
        int año = hoy.Year;
        int mes = hoy.Month;

        // Primer día del mes
        DateTime primerDia = new DateTime(año, mes, 1);

        // Nombre del mes y año
        string nombreMes = primerDia.ToString("MMMM", new CultureInfo("es-ES"));
        Console.WriteLine($"\n     {nombreMes.ToUpper()} {año}\n");

        // Encabezado
        Console.WriteLine("lu ma mi ju vi sá do");

        // Espacios antes del primer día
        int primerDiaSemana = ((int)primerDia.DayOfWeek + 6) % 7; // lunes = 0
        for (int i = 0; i < primerDiaSemana; i++)
        {
            Console.Write("   ");
        }

        // Imprimir días del mes
        int diasEnMes = DateTime.DaysInMonth(año, mes);
        for (int dia = 1; dia <= diasEnMes; dia++)
        {
            Console.Write($"{dia,2} ");

            primerDiaSemana++;
            if (primerDiaSemana % 7 == 0)
                Console.WriteLine();
        }

        Console.WriteLine("\n\nPresione una tecla para salir...");
        Console.ReadKey();
    }
}
