using System;

class LoopByStep3
{
    //1.Числата от 1 до N през 3
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        for (int k = 1; k <= n; k += 3)
        {
            Console.WriteLine(k);
        }
    }
}

