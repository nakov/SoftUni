using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfEndNumbers
{
    /* 
    Въведете списък от цели числа и изведете тези от тях, които са равни на минималния или максималния елемент.
    */
    class Solution
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var max = nums[0];
            var min = nums[0];

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > max) max = nums[i];
                if (nums[i] < min) min = nums[i];
            }

            List<int> outputList = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == max)
                {

                    outputList.Add(nums[i]);
                }
                else if (nums[i] == min)
                {
                    outputList.Insert(0,nums[i]);
                }
            }

            Console.WriteLine(string.Join(" ", outputList));
        }
    }
}
