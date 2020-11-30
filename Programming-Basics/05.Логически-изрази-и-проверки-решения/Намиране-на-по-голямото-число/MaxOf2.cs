using System;

class MaxOf2
{
    //4.Намиране на по-голямото число
    static void Main()
    {
        Console.WriteLine("Enter two integers:");
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("Greater number: " + a);
        }
        else
        {
            Console.WriteLine("Greater number: " + b);
        }
    }
}

