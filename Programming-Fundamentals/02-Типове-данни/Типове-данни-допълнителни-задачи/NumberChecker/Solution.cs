using System;

namespace NumberChecker
{
    class Solution
    {
        /* 2.	Проверка на число
        Напишете програма, която проверява дали дадено число е цяло или с 
        плаваща запетая и изведете  “floating-point” или “integer”, според случая.Ще бъдат въвеждани само числа.
        */

        static void Main(string[] args)
        {
            try
            {
                var number = long.Parse(Console.ReadLine());

                Console.WriteLine("integer");

            }

            catch (Exception)
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
