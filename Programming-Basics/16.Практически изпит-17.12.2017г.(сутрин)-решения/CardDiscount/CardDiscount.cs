using System;

class CardDiscount
{
    //2. Отстъпка
    static void Main()
    {
        string model = Console.ReadLine();
        int VIN = int.Parse(Console.ReadLine());
        string condition = Console.ReadLine();
        double price = double.Parse(Console.ReadLine());

        double profit = price * 15 / 100;

        if (condition == "good"
            && VIN < 90000 && VIN % 2 == 0
            && profit > 400)
        {
            Console.WriteLine($"yes - {model}");
            Console.WriteLine($"profit - {profit:f2}");
        }
        else
        {
            Console.WriteLine("no");
            if (condition == "bad")
            {
                Console.WriteLine("The car is in bad condition");
            }
            if (VIN > 90000 || VIN % 2 != 0 || VIN < 0)
            {
                Console.WriteLine($"VIN {VIN} is not valid");
            }
            if (profit < 400)
            {
                Console.WriteLine($"Cannot make discount, profit too low - {profit:f2}");
            }
        }
    }
}
