using System;

class OddOrEven
{
    //3.Четно или нечетно число
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("even");
        }
        else
        {
            Console.WriteLine("odd");
        }
    }
}

