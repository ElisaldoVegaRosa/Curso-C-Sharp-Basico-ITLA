using System;

namespace CalculadoraConMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Calculadora\n");
                Console.WriteLine("1- Suma");
                Console.WriteLine("2- Resta");
                Console.WriteLine("3- Multiplicación");
                Console.WriteLine("4- División");
                Console.WriteLine("5- Elevar un número a la potencia");
                Console.WriteLine("6- Salir");
                Console.Write("\nSeleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                if (opcion >= 1 && opcion <= 5)
                {
                    Console.Write("Ingrese el primer número: ");
                    double num1 = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese el segundo número: ");
                    double num2 = double.Parse(Console.ReadLine());

                    double resultado = 0;

                    switch (opcion)
                    {
                        case 1:
                            resultado = num1 + num2;
                            break;
                        case 2:
                            resultado = num1 - num2;
                            break;
                        case 3:
                            resultado = num1 * num2;
                            break;
                        case 4:
                            if (num2 != 0)
                                resultado = num1 / num2;
                            else
                            {
                                Console.WriteLine("No se puede dividir entre cero.");
                                Console.ReadKey();
                                continue;
                            }
                            break;
                        case 5:
                            resultado = Math.Pow(num1, num2);
                            break;
                    }

                    Console.WriteLine($"\nResultado: {resultado}");
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }
                else if (opcion != 6)
                {
                    Console.WriteLine("Opción inválida. Presione una tecla para intentar de nuevo.");
                    Console.ReadKey();
                }

            } while (opcion != 6);

            Console.WriteLine("Gracias por usar la calculadora. ¡Hasta luego!");
        }
    }
}
