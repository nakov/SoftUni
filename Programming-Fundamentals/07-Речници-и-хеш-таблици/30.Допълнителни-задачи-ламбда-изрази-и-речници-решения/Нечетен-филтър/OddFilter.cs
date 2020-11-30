using System;
using System.Collections.Generic;
using System.Linq;

class OddFilter
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        List<int> oddNumbers = new List<int>();

        oddNumbers = numbers.Where(x => x % 2 == 0).ToList();

        double average = oddNumbers.Average();

        for (int i = 0; i < oddNumbers.Count; i++)
        {
            if (oddNumbers[i] > average)
            {
                oddNumbers[i] += 1;
            }
            else if (oddNumbers[i] <= average)
            {
                oddNumbers[i] -= 1;
            }
        }

        Console.WriteLine(string.Join(" ", oddNumbers));
    }
}

