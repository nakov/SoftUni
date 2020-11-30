using System;

class SumOfTheOthers
{
    //10.Елемент, равен на сумата на останалите
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var sum = 0;
        var max = -1000000000000000;
        for (var i = 0; i < n; i++)
        {
            var next = int.Parse(Console.ReadLine());
            sum += next;
            if (next > max) max = next;
        }
        // Проверка
        if (sum - max == max)
            Console.WriteLine("Yes\nSum = " + max);
        else
            Console.WriteLine("No\nDiff = " + Math.Abs(sum - 2 * max));
    }
}

