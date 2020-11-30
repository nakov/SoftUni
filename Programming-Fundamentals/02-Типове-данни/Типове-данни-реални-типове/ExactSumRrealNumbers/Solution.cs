using System;

namespace ExactSumRrealNumbers
{
    class Solution
    {
        /* 9. Точна сума на реални числа
        Напишете програма, която въвежда n числа и изчислява и извежда тяхната точна сума (без закръгляне).
        */
        static void Main(string[] args)
        {
            var numbers = decimal.Parse(Console.ReadLine());
            decimal result = 0;
            for (int i = 0; i < numbers; i++)
            {
                result+= decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(result);
        }
    }
}
