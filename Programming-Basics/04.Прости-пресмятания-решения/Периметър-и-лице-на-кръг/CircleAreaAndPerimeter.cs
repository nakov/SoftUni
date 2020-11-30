using System;
class CircleAreaAndPerimeter
{
    //2.Периметър и лице на кръг
    static void Main()
    {
        var r = double.Parse(Console.ReadLine());
        var area = Math.Round(Math.PI * r * r, 2);
        var perimeter = Math.Round(2 * Math.PI * r, 2);
        Console.WriteLine("Area = " + area);
        Console.WriteLine("Perimeter = " + perimeter);
    }
}

