using System;

class Resell
{
    //1. Препродажба
    static void Main()
    {
        string model = Console.ReadLine();
        double price = double.Parse(Console.ReadLine());
        double days = double.Parse(Console.ReadLine());

        double priceWithTaxes = (price * 120 / 100) + 275;
        double moneyFromStaying = days * 20;
        double totalPrice = priceWithTaxes + moneyFromStaying;
        double profit = totalPrice * 15 / 100;

        Console.WriteLine($"The {model} with initial price of {price:f2} BGN will sell for {(totalPrice + profit):f2} BGN");
        Console.WriteLine($"Profit: {profit:f2} BGN");
    }
}
