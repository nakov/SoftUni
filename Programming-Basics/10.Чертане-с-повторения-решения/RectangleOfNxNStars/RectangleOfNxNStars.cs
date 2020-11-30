using System;

class RectangleOfNxNStars
{
    //2.Правоъгълник от N x N звездички
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

