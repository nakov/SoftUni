using System;
using System.Collections.Generic;
using System.Linq;

class FoldAndSum
{
    static void Main()
    {
        var numList = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
        var quaterLenth = numList.Count / 4;
        var foldedNums = numList
            .Skip(quaterLenth * 3)
            .Reverse()
            .ToList();
        foldedNums = new List<int>(
            numList
            .Take(quaterLenth)
            .Reverse()
            .ToList()
            .Concat(foldedNums)
            );
        numList = numList
            .Skip(quaterLenth)
            .Take(quaterLenth * 2)
            .ToList();
        var result = new List<int>();
        for (int i = 0; i < quaterLenth * 2; i++)
        {
            result.Add(numList[i] + foldedNums[i]);
        }

        Console.WriteLine(string.Join(" ", result));
    }
}
