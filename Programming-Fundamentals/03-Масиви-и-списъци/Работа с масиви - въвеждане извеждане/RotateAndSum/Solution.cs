using System;
using System.Linq;

namespace RotateAndSum
{
    /* 
    "Завъртане на масив на дясно" означава да преместим неговия последен елемент на първо място: {1, 2, 3} -> {3, 1, 2}. 
    Напишете програма, която въвежда масив от n цели числа (разделени с интервал на един ред) 
    и цяло число k, завърта k пъти надясно и сумира получените масиви след всяко завъртане."
    */
    class Solution
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            // Обработка
            int[] sum = new int[nums.Length];
            while (k > 0)
            {
                nums = Rotate(nums);
                sum = Sum(sum, nums);
                k--;
            }
            Console.WriteLine(string.Join(" ", sum));
        }

        // Въртене
        static int[] Rotate(int[] nums)
        {
            var part1 = nums.Take(nums.Length - 1).ToArray();
            var part2 = nums.Skip(nums.Length - 1).Take(1).ToArray();
            return part2.Concat(part1).ToArray();
        }

        // Сумиране
        static int[] Sum(int[] a, int[] b)
        {
            var sum = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                sum[i] = a[i] + b[i];
            return sum;
        }
    }

}
