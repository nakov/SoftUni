using System;

class Harvest
{
    // 4. Реколта
    static void Main()
    {
        var x = double.Parse(Console.ReadLine());
        var y = double.Parse(Console.ReadLine());
        var z = double.Parse(Console.ReadLine());
        var workers = int.Parse(Console.ReadLine());

        var h = (x * y) * 0.4;
        var w = (h / 2.5);
        if (w >= z)
        {
            var left = w - z;
            Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(w));
            Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(left), Math.Ceiling(left / workers));
        }
        else
        {
            Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(z - w));
        }
    }
}

