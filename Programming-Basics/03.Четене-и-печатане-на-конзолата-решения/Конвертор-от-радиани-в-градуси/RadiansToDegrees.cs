using System;

class RadiansToDegrees
{
    //6.*Конвертор от радиани в градуси 
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double g = r * 180 / Math.PI;
        Console.WriteLine(Math.Round(g));
    }
}

