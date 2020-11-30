using System;

class FigureArea
{
    //7.Лица на фигури
    static void Main()
    {
        var fig = Console.ReadLine();
        var result = 0.0;
        if (fig == "square")
        {
            var a = double.Parse(Console.ReadLine());
            result = a * a;
        }
        else if (fig == "rectangle")
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            result = a * b;
        }
        else if (fig == "circle")
        {
            var r = double.Parse(Console.ReadLine());
            result = Math.PI * r * r;
        }
        else
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            result = (a * h) / 2.0;
        }

        Console.WriteLine(Math.Round(result, 3));
    }
}

