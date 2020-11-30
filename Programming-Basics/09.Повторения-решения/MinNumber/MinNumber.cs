using System;

class MinNumber
{
    //6.Най-малко число
    static void Main()
    {
        // Въвеждаме брой на числата с които ще работим
        var n = int.Parse(Console.ReadLine());
        // създаваме променлива в която ще получим най-малкото
        var min = 1000;
        // Обхождаме N на брой пъти
        for (int i = 0; i < n; i++)
        {
            // Следващо число
            var next = int.Parse(Console.ReadLine());
            // Проверяваме дали е по-малко
            if (next < min) min = next;
        }
        // Отпечатваме какво се е получило в min
        Console.WriteLine(min);
    }
}
