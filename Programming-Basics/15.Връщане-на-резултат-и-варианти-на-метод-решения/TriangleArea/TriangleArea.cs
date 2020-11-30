using System;

class TriangleArea
{
    // 1. Лице на триъгълник
    static double Area(double a, double h)
    {
        return a * h / 2.0;
    }

    // Главен метод 
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine(Area(a, h));
    }
}
