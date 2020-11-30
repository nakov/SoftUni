using System;
using System.Linq;

class SortHours
{
    static void Main()
    {
        var times = Console.ReadLine().Split().OrderBy(x => x).ToList();
        Console.WriteLine(string.Join(", ", times));
    }
}
