using System;

class SumOfNumbers
{
    //4.Сумиране на числа
    static void Main()
    {
        // Въвеждаме брой на числата които ще сумираме
        var n = int.Parse(Console.ReadLine());
        // създаваме променлива в която ще получим сума
        var sum = 0;
        // Обхождаме N на брой пъти
        for (int i = 0; i < n; i++)
        {
            // Следващо число
            var next = int.Parse(Console.ReadLine());
            // Добавяме всяко следващо число към сумата
            sum = sum + next;
        }
        // Отпечатваме какво се е получило в сумата
        Console.WriteLine(sum);
    }
}
