using System;

class DiamondOfStars
{
    //6.Ромбче от звездички
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        // Top
        for (var row = 1; row <= n; row++)
        {
            for (var col = 1; col <= n - row; col++)
                Console.Write(" ");
            Console.Write("*");
            for (var col = 1; col < row; col++)
                Console.Write(" *");
            Console.WriteLine();
        }
        // Bottom
        for (var row = n - 1; row >= 1; row--)
        {
            for (var col = 1; col <= n - row; col++)
                Console.Write(" ");
            Console.Write("*");
            for (var col = 1; col < row; col++)
                Console.Write(" *");
            Console.WriteLine();
        }
    }
}

