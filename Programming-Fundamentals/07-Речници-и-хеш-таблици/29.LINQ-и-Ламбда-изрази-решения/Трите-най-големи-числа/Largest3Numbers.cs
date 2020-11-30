using System;
using System.Linq;

class Largest3Numbers
{
    static void Main()
    {
        var numList = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .OrderByDescending(n => n)
            .Take(3)
            .ToList();
        Console.WriteLine(string.Join(" ", numList));
    }
}
