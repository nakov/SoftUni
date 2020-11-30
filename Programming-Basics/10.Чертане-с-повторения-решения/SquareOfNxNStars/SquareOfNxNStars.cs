using System;

class SquareOfNxNStars
{
    //3.Квадрат от звездички
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        for (int r = 1; r <= n; r++)
        {
            Console.Write("*");
            for (int c = 1; c < n; c++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }
    }
}

