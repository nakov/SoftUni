using System;

namespace SumOfChars
{
    /*
     Напишете програма, която сумира ASCII кодовете на n знака и извежда сумата им.
     */
    class Solution
    {
        static void Main(string[] args)
        {
            byte charsCount = byte.Parse(Console.ReadLine());
            int sum = 0;
            while (charsCount > 0)
            {
                sum += char.Parse(Console.ReadLine());
                charsCount--;
            }
            Console.WriteLine("The sum equals: {0}", sum);
        }
    }
}
