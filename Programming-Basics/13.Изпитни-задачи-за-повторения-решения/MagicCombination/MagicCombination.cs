using System;

class MagicCombination
{
    // 6. Магически числа
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        for (int i = 100000; i < 1000000; i++)
            if ((i % 10) *
                (i / 10 % 10) *
                (i / 100 % 10) *
                (i / 1000 % 10) *
                (i / 10000 % 10) *
                (i / 100000) == n)
                Console.Write(i + " ");

        Console.WriteLine();
    }
}

