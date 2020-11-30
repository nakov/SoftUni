using System;
using System.Collections.Generic;
using System.Linq;

namespace EnterListFromTheConsoleUsingOneLine
{
    /* 
    Въведете списък от цели числа и го изведете в конзолата. Елементите на списъка ще получите от единствен ред, 
    разделени с интервали.
    - Първо създайте нов C# конзолен проект и задайте име "ListInputOutputLine".
    - Въведете списъка от числа от един ред, чрез следния код:
    */
    class Solution
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            // Отпечатване на списък от цели числа
            for (int index = 0; index < nums.Count; index++)
                Console.WriteLine("nums[{0}] = {1}", index, nums[index]);
        }
    }
}
