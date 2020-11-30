using System;

class EvenOddSums
{
    // 8. Четна и нечетна сума
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        // намиране на четната и нечетната суми
        var oddSum = 0;
        var evenSum = 0;
        for (var i = 0; i < n; i++)
        {
            var element = int.Parse(Console.ReadLine());
            if (i % 2 == 0) oddSum += element;
            else evenSum += element;
        }
        // Проверка
        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Sum = " + oddSum);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("Diff = " +
            Math.Abs(oddSum - evenSum));
        }
    }
}

