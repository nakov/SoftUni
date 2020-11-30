using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativeNumbers
{
    /*
     Въведете списък от цели числа, премахнете всички отрицателни числа от него и го изведете на конзолата в обратен ред. 
     В случай, че в списъка не са останали елементи, изведете “empty”.
     */
    class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int index = 0; index < nums.Count; index++)
                if (nums[index] < 0)
                {
                    nums.RemoveAt(index);
                    index--; // връщаме индекса назад, понеже намаляме броя на елементите с единица и следващия елемент се е мръднал наляво
                }
            nums.Reverse();
            if (nums.Count>0)
            {
                Console.WriteLine(string.Join(" ", nums));

            }
            else
            {
                Console.WriteLine("Empty");
            }
            
        }
    }
}
