using System;

class Division
{
    // 2. Деление без остатък
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var p1 = 0.00;
        var p2 = 0.00;
        var p3 = 0.00;
        for (int i = 0; i < n; i++)
        {
            var next = int.Parse(Console.ReadLine());
            if (next % 2 == 0) p1++;
            if (next % 3 == 0) p2++;
            if (next % 4 == 0) p3++;
        }
        Console.WriteLine("{0:f2}%", p1 / n * 100);
        Console.WriteLine("{0:f2}%", p2 / n * 100);
        Console.WriteLine("{0:f2}%", p3 / n * 100);
    }
}

