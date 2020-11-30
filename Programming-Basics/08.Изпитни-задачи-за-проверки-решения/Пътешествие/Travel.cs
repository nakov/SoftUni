using System;

class Travel
{
    //6.**Пътешествие
    static void Main()
    {
        // Входни данни
        var budget = double.Parse(Console.ReadLine());
        var season = Console.ReadLine();

        // Цена и местоположение            
        var price = 0.0;
        var location = ""; // Bulgaria, Balkans or Europe
        var place = ""; // Camp or Hotel

        if (budget <= 100)
        {
            location = "Bulgaria";
            if (season == "summer")
            {
                price = budget * 0.3;
                place = "Camp";
            }
            else
            {
                price = budget * 0.7;
                place = "Hotel";
            }
        }
        else if (budget <= 1000)
        {
            location = "Balkans";
            if (season == "summer")
            {
                price = budget * 0.4;
                place = "Camp";
            }
            else
            {
                price = budget * 0.8;
                place = "Hotel";
            }
        }
        else
        {
            location = "Europe";
            price = budget * 0.9;
            place = "Hotel";
        }

        // Информация за потребителя
        Console.WriteLine("Somewhere in {0}", location);
        Console.WriteLine("{0} - {1:f2}", place, price);
    }
}

