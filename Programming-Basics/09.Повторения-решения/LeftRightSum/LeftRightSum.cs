using System;

class LeftRightSum
{
    // 7. Lява и дясна сума
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        // Лява сума
        var leftSum = 0;
        for (var i = 0; i < n; i++)
            leftSum += int.Parse(Console.ReadLine());
        // Дясна сума
        var rightSum = 0;
        for (var i = 0; i < n; i++)
            rightSum += int.Parse(Console.ReadLine());
        // Проверка
        if (leftSum == rightSum)
            Console.WriteLine("Yes, sum = " + leftSum);
        else
            Console.WriteLine("No, diff = " +
            Math.Abs(rightSum - leftSum));
    }
}

