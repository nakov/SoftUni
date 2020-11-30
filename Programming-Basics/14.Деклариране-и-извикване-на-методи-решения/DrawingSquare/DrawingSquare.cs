using System;

class DrawingSquare
{
    // 4. Рисуване на запълнен квадрат

    // Заглавен ред 
    static void PrintHeaderRow(int n)
    {
        Console.WriteLine(new string('-', 2 * n));
    }

    // Среден ред
    static void PrintMiddleRow(int n)
    {
        Console.Write('-');
        for (int i = 1; i < n; i++) Console.Write("\\/");
        Console.WriteLine('-');
    }

    // Главна функция
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintHeaderRow(n);
        for (int i = 0; i < n - 2; i++) PrintMiddleRow(n);
        PrintHeaderRow(n);
    }
}
