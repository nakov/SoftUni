using System;
using System.Linq;

namespace MostFrequentNumber
{
    /*
    Напишете програма, която намира най-често срещаното число в дадена последователност.
    - Числата ще са в интервала [0 ... 65535].
    - В случай, че има няколко най-често срещани числа, изведете най-лявото от тях.
    */
    class Solution
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxCount = 0;
            int repeatingNumber = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                int currentCount = 0;

                for (int j = i; j < sequence.Length; j++)
                {
                    if (sequence[i] == sequence[j])
                    {
                        currentCount++;
                    }
                }

                if (currentCount > maxCount)
                {
                    repeatingNumber = sequence[i];
                    maxCount = currentCount;
                }
            }

            Console.WriteLine(repeatingNumber);
        }
    }
}
