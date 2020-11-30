using System;

class BonusPoint
{
    //2.Бонус точки
    static void Main()
    {
        var num = double.Parse(Console.ReadLine());

        var bonusScore = 0.0;
        if (num <= 100) bonusScore = 5;
        else if (num <= 1000) bonusScore = num * 0.2;
        else bonusScore = num * 0.1;

        if (num % 10 == 5) bonusScore += 2;
        else if (num % 2 == 0) bonusScore += 1;

        Console.WriteLine(bonusScore);
        Console.WriteLine(num + bonusScore);
    }
}

