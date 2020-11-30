using System;

class PowerOfNumber
{
    // 2. Степен на число
    static double RiseNumber(double a, int b)
    {
        double result = a;
        for (int i = 1; i < b; i++) result *= a;
        return result;
    }

    // Главен метод
    static void Main()
    {
        var a = double.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        Console.WriteLine(RiseNumber(a, b));
    }
}
