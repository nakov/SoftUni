using System;

class Money
{
    //10.*Парички
    static void Main()
    {
        int Onebitcoin = 1168; // лева
        double oneChineseYuan = 0.15; // долара
        double OneDollar = 1.76; // лева
        double OneEuro = 1.95; // лева

        double bitcoins = double.Parse(Console.ReadLine()); // – броят биткойни

        double chineseYuan = double.Parse(Console.ReadLine()); // – броят китайски юана

        double commission = double.Parse(Console.ReadLine()); // комисионната;

        bitcoins = bitcoins * Onebitcoin; // 1168
        chineseYuan = oneChineseYuan * chineseYuan; // 0.75 долара
        chineseYuan = chineseYuan * OneDollar; // 1.32;

        bitcoins = bitcoins + chineseYuan; // 1169.32
        bitcoins = bitcoins / OneEuro; // 599.651282051282 евро;

        commission = bitcoins * commission / 100; // 29.9825641025641

        double result = bitcoins - commission;
        Console.WriteLine($"{result:f2}");
    }
}

