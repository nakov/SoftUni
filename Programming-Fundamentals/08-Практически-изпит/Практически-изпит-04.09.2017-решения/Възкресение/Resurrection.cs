using System;

class Resurrection
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        decimal years = 0;
        for (int i = 0; i < n; i++)
        {
            long totalLength = long.Parse(Console.ReadLine());
            decimal totalwidth = decimal.Parse(Console.ReadLine());
            int wingLength = int.Parse(Console.ReadLine());

            years = (totalLength * totalLength) * ((totalwidth) + 2 * wingLength);

            Console.WriteLine(years);
        }
    }
}

