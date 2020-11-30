using System;

class ThreeEqualNumbers
{
    //8.Три еднакви числа
    static void Main()
    {
        var a = double.Parse(Console.ReadLine());
        var b = double.Parse(Console.ReadLine());
        var c = double.Parse(Console.ReadLine());
        if (a == b && b == c)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

