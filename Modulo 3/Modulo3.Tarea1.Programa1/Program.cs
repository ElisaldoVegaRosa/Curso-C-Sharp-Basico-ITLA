using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese su fecha de nacimiento (dd/mm/yyyy): ");
        string input = Console.ReadLine();

        if (DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaNacimiento))
        {
            // Obtener el día de la semana
            string diaSemana = fechaNacimiento.ToString("dddd", new CultureInfo("es-ES"));

            Console.WriteLine($"Naciste un {diaSemana}.");
        }
        else
        {
            Console.WriteLine("Formato de fecha inválido. Usa dd/mm/yyyy.");
        }

        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }
}
