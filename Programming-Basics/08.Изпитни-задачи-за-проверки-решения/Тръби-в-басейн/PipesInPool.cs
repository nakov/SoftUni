using System;

class PipesInPool
{
    //2.*Тръби в басейн 
    static void Main()
    {
        int v = int.Parse(Console.ReadLine());
        int p1 = int.Parse(Console.ReadLine());
        int p2 = int.Parse(Console.ReadLine());
        double hours = double.Parse(Console.ReadLine());

        double water = p1 * hours + p2 * hours;

        if (water <= v)
        {
            double waterPersent = Math.Floor(water / v * 100);
            double p1Persent = Math.Floor(p1 * hours / water * 100);
            double p2Persent = Math.Floor(p2 * hours / water * 100);

            Console.WriteLine($"The pool is {waterPersent}% full. Pipe 1: {p1Persent}%. Pipe 2: {p2Persent}%.");
        }
        else
        {
            double waterMore = water - v;

            Console.WriteLine($"For {hours} hours the pool overflows with {waterMore} liters.");
        }
    }
}
