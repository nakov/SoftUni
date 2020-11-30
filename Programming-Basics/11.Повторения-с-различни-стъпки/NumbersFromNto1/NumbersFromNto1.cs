using System;

class NumbersFromNto1
{
    //2.Числата от N до 1 в обратен ред
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        for (int k = n; k > 0; k--)
        {
            Console.WriteLine(k);
        }
    }
}

