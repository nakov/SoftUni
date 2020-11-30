using System;

class ExcellentOrNot
{
    //2.Отлична оценка или не
    static void Main()
    {
        var grade = double.Parse(Console.ReadLine());
        if (grade >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
        else
        {
            Console.WriteLine("Not excellent.");
        }
    }
}

