using System;

class LatinLetters
{
    //3.Всички латински букви
    static void Main()
    {
        for (var letter = 'a'; letter <= 'z'; letter++)
        {
            Console.Write(letter + " ");
        }
        Console.WriteLine();
    }
}
