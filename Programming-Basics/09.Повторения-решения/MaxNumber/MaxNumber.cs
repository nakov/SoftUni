using System;

class MaxNumber
{
    //5.Най-голямо число
    static void Main()
    {
        // Въвеждаме брой на числата с които ще работим
        var n = int.Parse(Console.ReadLine());
        // създаваме променлива в която ще получим най-голямото
        var max = -1000;
        // Обхождаме N на брой пъти
        for (int i = 0; i < n; i++)
        {
            // Следващо число
            var next = int.Parse(Console.ReadLine());
            // Проверяваме дали е по-голямо
            if (next > max) max = next;
        }
        // Отпечатваме какво се е получило в max
        Console.WriteLine(max);
    }
}
