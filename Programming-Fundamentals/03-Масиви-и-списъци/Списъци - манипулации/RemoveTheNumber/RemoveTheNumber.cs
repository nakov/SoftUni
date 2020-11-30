using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveTheNumber
{
    /*
     Въведете списък от цели числа и премахнете всички срещания в списъка на последното число. 
     Елементите на списъка ще получите от единствен ред, разделени с интервали.
     */
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int number = nums[nums.Count - 1];
            while (nums.Contains(number))
            {
                nums.Remove(number);
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
