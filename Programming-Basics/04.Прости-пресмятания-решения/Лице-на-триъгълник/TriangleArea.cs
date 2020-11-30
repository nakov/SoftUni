using System;

class TriangleArea
{
    //4.Лице на триъгълник
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double area = a * h / 2;
        Console.WriteLine("Triangle area = " + Math.Round(area, 2));
    }
}

