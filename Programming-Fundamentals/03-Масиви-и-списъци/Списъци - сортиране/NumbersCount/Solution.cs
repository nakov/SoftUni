using System;
using System.Linq;

namespace NumbersCount
{
    /*
     Въведете списък от цели числа в интервала [0…1000] и ги изведете в нарастващ ред заедно с броя на срещанията им.
     */
    class Solution
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var counts = new int[nums.Max() + 1];

            foreach (var num in nums) counts[num]++;

            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                    Console.WriteLine($"{i} -> {counts[i]}");
            }
        }
    }
}
