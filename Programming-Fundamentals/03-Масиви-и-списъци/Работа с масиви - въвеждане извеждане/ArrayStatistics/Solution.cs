using System;
using System.Linq;

namespace ArrayStatistics
{
    /*
    Напишете програма, която получава масив от цели числа (разделени  с интервал)
    и извежда най-малкия елемент, най-големия елемент, сумата на елементите и средната им стойност.
    */
    class Solution
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            numbers.Min();
            numbers.Max();
            numbers.Sum();
            numbers.Average();
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}
