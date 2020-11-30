using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersSorting
{
    /*
     Въведете списък от цели числа и го сортирайте. 
     */
    class Solution
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split().Select(double.Parse).ToList();
            nums.Sort();
            Console.WriteLine(string.Join(" <= ", nums));
        }
    }
}
