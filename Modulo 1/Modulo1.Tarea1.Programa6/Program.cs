using System;

class Fibonacci
{
    static void Main()
    {
        Console.WriteLine("Serie Fibonacci hasta el 50:");

        int a = 0, b = 1, c = 0;

        Console.WriteLine(a);
        Console.WriteLine(b);

        while (c <= 50)
        {
            c = a + b;
            if (c <= 50)
            {
                Console.WriteLine(c);
            }
            a = b;
            b = c;
        }
    }
}
