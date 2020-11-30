using System;

class CurrencyCoverter
{
    //5.*Междувалутен конвертор
    static void Main()
    {
        var sum = double.Parse(Console.ReadLine());
        var firstCurrency = Console.ReadLine();
        var secondCurrency = Console.ReadLine();

        double sumInBGN = 1;
        double sumInCurrency = 1;

        if (firstCurrency == "BGN")
            sumInBGN = sum * 1;
        else if (firstCurrency == "USD")
            sumInBGN = sum * 1.79549;
        else if (firstCurrency == "EUR")
            sumInBGN = sum * 1.95583;
        else if (firstCurrency == "GBP")
            sumInBGN = sum * 2.53405;

        if (secondCurrency == "BGN")
            sumInCurrency = sumInBGN;
        else if (secondCurrency == "USD")
            sumInCurrency = sumInBGN / 1.79549;
        else if (secondCurrency == "EUR")
            sumInCurrency = sumInBGN / 1.95583;
        else if (secondCurrency == "GBP")
            sumInCurrency = sumInBGN / 2.53405;

        Console.WriteLine(Math.Round(sumInCurrency, 2) + " " + secondCurrency);
    }
}

