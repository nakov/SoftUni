using System;

class SeasonSale
{
    //3. Сезонна продажба
    static void Main()
    {
        string model = Console.ReadLine();
        string type = Console.ReadLine().ToLower();
        string season = Console.ReadLine().ToLower();
        string condition = Console.ReadLine().ToLower();
        double initialPrice = double.Parse(Console.ReadLine());
        double wantedProfit = double.Parse(Console.ReadLine());

        double profit = 0.0;

        if (type == "suv")
        {
            if (condition == "perfect")
            {
                profit = initialPrice * 30 / 100;
            }
            else if (condition == "good")
            {
                profit = initialPrice * 20 / 100;
            }
            else if (condition == "bad")
            {
                profit = initialPrice * 10 / 100;
            }
        }
        else if (type == "sedan")
        {
            if (condition == "perfect")
            {
                profit = initialPrice * 25 / 100;
            }
            else if (condition == "good")
            {
                profit = initialPrice * 15 / 100;
            }
            else if (condition == "bad")
            {
                profit = initialPrice * 10 / 100;
            }
        }

        if (season == "winter")
        {
            profit -= 200;
        }

        if (profit >= wantedProfit)
        {
            Console.WriteLine($"The profit on {model} will be good - {profit:f2} BGN");
        }
        else
        {
            Console.WriteLine("The car is not worth selling now");
            Console.WriteLine($"Need {(wantedProfit - profit):f2} more profit");
        }
    }
}
