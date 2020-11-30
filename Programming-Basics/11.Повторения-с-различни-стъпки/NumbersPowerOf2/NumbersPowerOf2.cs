using System;

class NumbersPowerOf2
{
    //3.Числа– степени на 2 
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var num = 1;
        while (n > -1)
        {
            Console.WriteLine(num);
            num *= 2;
            n--;
        }
    }
}

