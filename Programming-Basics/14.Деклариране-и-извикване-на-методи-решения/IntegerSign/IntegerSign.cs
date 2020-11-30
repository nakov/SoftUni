using System;

class IntegerSign
{
    // 2. Знак на цяло число
    static void PrintSign(int number)
    {
        if (number > 0) Console.WriteLine("The number {0} is positive.", number);
        else if (number < 0) Console.WriteLine("The number {0} is negative.", number);
        else Console.WriteLine("The number {0} is zero.", number);
    }

    // Главен метод
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintSign(n);
    }
}
