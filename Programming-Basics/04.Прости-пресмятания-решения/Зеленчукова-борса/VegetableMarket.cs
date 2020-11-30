using System;

class VegetableMarket
{
    //8.*Зеленчукова борса
    static void Main()
    {
        var veggie = double.Parse(Console.ReadLine());
        var fruit = double.Parse(Console.ReadLine());
        var vegQ = int.Parse(Console.ReadLine());
        var fruQ = int.Parse(Console.ReadLine());

        double EUR = 1.94;

        double totalV = veggie * vegQ;
        double totalF = fruit * fruQ;

        Console.WriteLine((totalV + totalF) / EUR);
    }
}
