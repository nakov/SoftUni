using System;

class SunGlasses
{
    //8.Слънчеви очила
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        int middle = (n - 1) / 2 - 1;

        // Top
        Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
        // Middle
        for (int i = 0; i < n - 2; i++)
        {
            var glass = "*" + new string('/', 2 * n - 2) + "*";
            if (i == middle)
            {
                Console.WriteLine(glass + new string('|', n) + glass);
            }
            else
            {
                Console.WriteLine(glass + new string(' ', n) + glass);
            }
        }
        // Bottom
        Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
    }
}

