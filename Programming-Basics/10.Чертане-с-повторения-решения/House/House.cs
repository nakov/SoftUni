using System;

class House
{
    //9.Къщичка
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var stars = 1;
        if (n % 2 == 0) stars++;
        for (int i = 0; i < (n + 1) / 2; i++)
        {
            // Draw the roof
            var padding = (n - stars) / 2;
            Console.Write(new string('-', padding));
            Console.Write(new string('*', stars));
            Console.WriteLine(new string('-', padding));
            stars = stars + 2;
        }
        for (int i = 0; i < n / 2; i++)
        {
            // Draw the house body
            Console.Write("|");
            Console.Write(new string('*', n - 2));
            Console.WriteLine("|");
        }
    }
}

