using System;

class PrintTriangle
{
    // 3. Принтиране на триъгълник
    static void PrintLine(int n)
    {
        for (int i = 1; i <= n; i++) Console.Write("{0} ", i);
        Console.WriteLine();
    }

    // Главен метод
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++) PrintLine(i);
        for (int i = n - 1; i >= 1; i--) PrintLine(i);
    }
}
