using System;

class Number100To200
{
    //5.Число от 100 до 200
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        if (num < 100)
        {
            Console.WriteLine("Less than 100");
        }
        else if (num <= 200)
        {
            Console.WriteLine("Between 100 and 200");
        }
        else
        {
            Console.WriteLine("Greater than 200");
        }
    }
}
