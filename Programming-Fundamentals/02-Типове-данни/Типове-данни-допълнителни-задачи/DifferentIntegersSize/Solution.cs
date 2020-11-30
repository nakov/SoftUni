using System;
using System.Numerics;

namespace DifferentIntegersSize
{
    /*
     Дадено е цяло число. Трябва да определите в кой тип може да се впише числото. 
     */
    class Solution
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            if (n <= long.MaxValue)
            {
                Console.WriteLine("{0} can fit in:", n);
                if (n >= sbyte.MinValue && n <= sbyte.MaxValue)
                {
                    Console.WriteLine("* sbyte");
                }
                if (n >= byte.MinValue && n <= byte.MaxValue)
                {
                    Console.WriteLine("* byte");
                }
                if (n >= short.MinValue && n <= short.MaxValue)
                {
                    Console.WriteLine("* short");
                }
                if (n >= ushort.MinValue && n <= ushort.MaxValue)
                {
                    Console.WriteLine("* ushort");
                }
                if (n >= int.MinValue && n <= int.MaxValue)
                {
                    Console.WriteLine("* int");
                }
                if (n >= uint.MinValue && n <= uint.MaxValue)
                {
                    Console.WriteLine("* uint");
                }
                if (n >= long.MinValue && n <= long.MaxValue)
                {
                    Console.WriteLine("* long");
                }
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", n);
            }
        }
    }
}
