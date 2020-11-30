using System;

class Tiles
{
    //9.*Ремонт на плочки
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        double W = double.Parse(Console.ReadLine());
        double L = double.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int O = int.Parse(Console.ReadLine());

        int totalArea = N * N;
        int benchArea = M * O;
        int coveredArea = totalArea - benchArea;
        double tileArea = W * L;
        double tiles = coveredArea / tileArea;
        double time = tiles * 0.2;

        Console.WriteLine($"{tiles:f2}");
        Console.WriteLine($"{time:f2}");
    }
}
