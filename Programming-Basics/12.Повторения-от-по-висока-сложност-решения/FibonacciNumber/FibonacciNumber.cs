using System;

class FibonacciNumber
{
    // 5. Числа на Фибоначи
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var a = 1;
        var b = 1;
        var c = a + b;
        while (true)
        {
            if (n <= 0) break;
            else n--;
            a = b;
            b = c;
            c = a + b;
        }
        Console.WriteLine(a);
    }
}

