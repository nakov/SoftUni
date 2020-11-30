using System;
using System.Linq;

namespace FoldAndSum
{
    /* 
    Въведете масив от  4*k  цели числа, сгънете го както е указано по-долу и изведете сумата на горния и долния ред 
    (всеки, съдържащ 2 * k  цели числа).
    */
    class Solution
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            nums = Fold(nums);
            Console.WriteLine(string.Join(" ", nums));
        }
        // Сгъване
        static int[] Fold(int[] nums)
        {
            var part1 = nums.Take(nums.Length / 4).ToArray();
            var part2 = nums.Skip(nums.Length / 4).Take(nums.Length / 2).ToArray();
            var part3 = nums.Skip(nums.Length * 3 / 4).Take(nums.Length / 4).ToArray();

            var a = (part1.Reverse()).Concat(part3.Reverse()).ToArray();
            var b = part2;

            return Sum(a, b);
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
