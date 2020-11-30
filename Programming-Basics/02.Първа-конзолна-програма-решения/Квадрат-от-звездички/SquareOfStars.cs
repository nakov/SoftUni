using System;

class SquareOfStars
{
    //6.*Квадрат от звездички
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string('*', n));

        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("*{0}*", new string(' ', n - 2));
        }

        Console.WriteLine(new string('*', n));
    }
}

