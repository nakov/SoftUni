using System;

class TravelPrice
{
    //1.*Цена за транспорт
    static void Main()
    {
        var n = double.Parse(Console.ReadLine());
        var time = Console.ReadLine();

        double result = 0.0;

        if (n < 20 && n > 0 && time == "day")
        {
            result = 0.70 + (n * 0.79);
        }
        else if (n < 20 && n > 0 && time == "night")
        {
            result = 0.70 + (n * 0.90);
        }
        else if (n >= 100 && n < 5001 && time == "day")
        {
            result = n * 0.06;
        }
        else if (n >= 100 && n < 5001 && time == "night")
        {
            result = n * 0.06;
        }
        else if (n >= 20 && n < 100 && time == "day")
        {
            result = n * 0.09;
        }
        else if (n >= 20 && n < 100 && time == "night")
        {
            result = n * 0.09;
        }

        Console.WriteLine($"{result:f2}");
    }
}
