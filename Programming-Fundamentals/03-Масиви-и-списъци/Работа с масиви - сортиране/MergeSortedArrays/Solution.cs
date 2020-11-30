using System;
using System.Linq;

namespace MergeSortedArrays
{
    /*
     Създайте програма, която по зададени два подредени във възходящ ред масиви от цели числа, 
    създава трети, който отново е подреден
     */
    class Solution
    {
        static void Main(string[] args)
        {
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] B = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] C = new int[A.Length + B.Length];

            // Merge
            for (int i = 0; i < A.Length; i++)
                C[i] = A[i];
            for (int i = A.Length; i < A.Length + B.Length; i++)
                C[i] = B[i - A.Length];

            // Sort
            for (int i = 0; i < C.Length; i++)
                for (int j = 0; j < C.Length; j++)
                    if (C[i] < C[j])
                    {
                        int temp = C[i];
                        C[i] = C[j];
                        C[j] = temp;
                    }

            // Print
            Console.WriteLine(string.Join(" ", C));
        }
    }
}
