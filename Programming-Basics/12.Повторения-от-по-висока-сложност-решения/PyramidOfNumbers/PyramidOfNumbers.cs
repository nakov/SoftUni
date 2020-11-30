using System;

class PyramidOfNumbers
{
    // 6. Пирамида от числа
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var m = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(m + " ");
                m++;
                if (m > n)
                {
                    Console.WriteLine();
                    return;
                }
            }
            Console.WriteLine();
        }
    }
}

