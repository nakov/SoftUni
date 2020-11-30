using System;

class NOD
{
    //7.Най-голям общ делител (НОД)
    static void Main()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        while (b != 0)
        {
            var old = b;
            b = a % b;
            a = old;
        }
        Console.WriteLine(a);
    }
}

