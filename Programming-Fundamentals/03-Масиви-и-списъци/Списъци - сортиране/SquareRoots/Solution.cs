using System;
using System.Collections.Generic;
using System.Linq;

namespace SquareRoots
{
    /*
     Въведете списък от цели числа и изведете всички числа квадрати от списъка в низходящ ред.  
    Число квадрат е цяло число, което е квадрат на друго цяло число. 
    Например, 1, 4, 9, 16 са числа квадрати.
     */
    class Solution
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var squares = new List<int>();

            foreach (var num in nums)
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                    squares.Add(num);

            squares.Sort();
            squares.Reverse();
            Console.WriteLine(string.Join(" ", squares));
        }
    }
}
