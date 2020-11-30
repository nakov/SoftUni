using System;
using System.Collections.Generic;
using System.Linq;

class MinMaxSumAverage
{
    static void Main()
    {
        var numCount = int.Parse(Console.ReadLine());
        var numList = new List<double>();
        while (numCount > 0)
        {
            numList.Add(int.Parse(Console.ReadLine()));
            numCount--;
        }

        var min = numList.Min();
        var max = numList.Max();
        var sum = numList.Sum();
        var average = numList.Average();

        Console.WriteLine($"Sum = {sum}");
        Console.WriteLine($"Min = {min}");
        Console.WriteLine($"Max = {max}");
        Console.WriteLine($"Average = {average}");
    }
}
