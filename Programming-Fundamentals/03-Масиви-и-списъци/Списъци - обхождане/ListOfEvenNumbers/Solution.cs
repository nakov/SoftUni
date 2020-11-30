﻿using System;
using System.Linq;

namespace ListOfEvenNumbers
{
    /* 
    Въведете списък от цели числа и изведете четните числа от списъка на един ред в конзолата. 
    Елементите на списъка ще получите от единствен ред, разделени с интервали.
    */
    class Solution
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 == 0) Console.Write($"{nums[i]} ");
            }
        }
    }
}
