﻿using System;

namespace Rectangle
{
    class Solution
    {
        /* 10. Правоъгълник
        Напишете програма, която изчислява за даден правоъгълник неговите обиколка, лице и диагонал по неговите страни.
        */
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double P = 2 * a + 2 * b;
            double S = a * b;
            decimal d = (decimal)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine(P);
            Console.WriteLine(S);
            Console.WriteLine(d);
        }
    }
}
