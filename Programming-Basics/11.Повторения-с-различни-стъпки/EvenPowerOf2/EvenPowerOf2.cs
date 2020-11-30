using System;

class EvenPowerOf2
{
    //4.Четни степени на 2
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var num = 1;
        while (n > -1)
        {
            Console.WriteLine(num);
            num *= 4;
            n -= 2;
        }
    }
}

