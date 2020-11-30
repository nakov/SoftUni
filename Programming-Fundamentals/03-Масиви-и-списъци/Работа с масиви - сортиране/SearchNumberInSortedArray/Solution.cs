using System;
using System.Linq;

namespace SearchNumberInSortedArray
{
    /*
     Даден е сортиран масив от цели числа и друго цяло число. Напишете алгоритъм, който извежда “Yes”  
    ако елемента се намира в масива  и  “No”  ако елемента не се намира в масива.
    */
    class Solution
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == n)
                {
                    found = true;
                    break;
                }
            }
            Console.WriteLine(found ? "Yes" : "No");
        }
    }
}
