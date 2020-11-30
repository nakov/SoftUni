using System;

class ExcellentResult
{
    //1.Проверка за отлична оценка
    static void Main()
    {
        var grade = double.Parse(Console.ReadLine());
        if (grade >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
    }
}

