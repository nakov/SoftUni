using System;
using System.Linq;

namespace InsertNumberInSortedArray
{
    /*
     Даден е сортиран масив от цели числа и друго цяло число. 
    Напишете алгоритъм, който вмъква  числото в масива, така, че масива отново да е подреден.
    */
    class Solution
    {
        static void Main(string[] args)
        {
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] B = new int[A.Length + 1];
            int placed = 0;
            for (int i = 0; i < B.Length; i++)
            {
                if (n >= A[i - placed] || placed == 1)
                {
                    B[i] = A[i - placed];
                }
                else
                {
                    B[i] = n;
                    placed = 1;
                }
            }
            Console.WriteLine(string.Join(" ", B));
        }
    }
}
