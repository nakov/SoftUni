using System;
using System.Linq;

class ShortWordsSorted
{
    static void Main()
    {
        var separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
        var wordsList = Console.ReadLine()
            .ToLower()
            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
            .Distinct()
            .Where(w => w.Length < 5)
            .OrderBy(w => w)
            .ToList();
        Console.WriteLine(string.Join(", ", wordsList));
    }
}
