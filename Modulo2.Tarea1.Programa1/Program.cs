using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];

        Console.WriteLine("Digite 10 números desordenados:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Ordenar el arreglo (de menor a mayor)
        Array.Sort(numeros);

        Console.WriteLine("\nNúmeros ordenados:");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(numeros[i]);
        }

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
