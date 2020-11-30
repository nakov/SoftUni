using System;
class OrderOf2kPlus1
{
    //5.Редица числа 2k+1
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var num = 1;
        while (num <= n)
        {
            Console.WriteLine(num);
            num = 2 * num + 1;
        }
    }
}

