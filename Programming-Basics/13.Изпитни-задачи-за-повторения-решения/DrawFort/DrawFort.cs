using System;

class DrawFort
{
    // 3. Чертане на крепост
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var v = n / 2;
        var t = 2 * n - (2 * v + 4);
        Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', v), new string('_', t));
        for (int i = 0; i < n - 3; i++)
        {
            Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));
        }
        Console.WriteLine("|{0}{1}{0}|", new string(' ', v + 1), new string('_', t));
        Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', v), new string(' ', t));
    }
}

