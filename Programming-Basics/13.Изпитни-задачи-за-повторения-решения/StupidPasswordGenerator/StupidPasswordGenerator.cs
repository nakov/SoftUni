using System;

class StupidPasswordGenerator
{
    // 6. Генератор за тъпи пароли
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var l = int.Parse(Console.ReadLine());

        for (var d1 = 1; d1 < n; d1++)
            for (var d2 = 1; d2 < n; d2++)
                for (var d3 = 'a'; d3 <= (char)(l + 96); d3++)
                    for (var d4 = 'a'; d4 <= (char)(l + 96); d4++)
                        for (var d5 = Math.Max(d1, d2) + 1; d5 <= n; d5++)
                            Console.Write("{0}{1}{2}{3}{4} ", d1, d2, d3, d4, d5);

        Console.WriteLine();
    }
}

