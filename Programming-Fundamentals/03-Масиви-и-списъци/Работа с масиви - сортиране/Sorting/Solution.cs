using System;
using System.Linq;

namespace Sorting
{
    /*
     От клавиатурата се въвежда  масив от цели числа. Сортирайте го в низходящ ред. Изведете резултата на един ред.
     */
    class Solution
    {
        static void Main(string[] args)
        {
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Sort
            for (int i = 0; i < A.Length; i++)
                for (int j = 0; j < A.Length; j++)
                    if (A[i] < A[j])
                    {
                        int temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }

            Console.WriteLine(string.Join(" ", A));
        }
    }
}
