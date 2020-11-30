using System;
using System.Linq;

namespace ReversedNumbersSum
{
    /* 
    Напишете програма, която прочита поредица от цели числа, преобръща техните цифри и ги сумира.
    */
    class Solution
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ');
            for (int i = 0; i < nums.Count(); i++)
            {
                nums[i] = String.Join("", nums[i].Reverse());
            }
            Console.WriteLine(nums.Select(int.Parse).Sum());
        }
    }
}
