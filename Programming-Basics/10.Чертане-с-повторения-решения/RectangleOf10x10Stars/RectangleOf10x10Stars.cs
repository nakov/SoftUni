using System;

class RectangleOf10x10Stars
{
    //1.Правоъгълник от 10 x 10 звездички
    static void Main()
    {
        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

