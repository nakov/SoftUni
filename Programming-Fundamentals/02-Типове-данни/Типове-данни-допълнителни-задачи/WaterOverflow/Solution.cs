using System;

namespace WaterOverflow
{
    class Solution
    {
        /*
        Имате съд за вода с капацитет от 255 литра. 
        На следващите n реда, ще получите литри вода, които трябва да налеете във вашия съд. 
        Ако капацитета на вашия съд не е  достатъчен, изведете “Insufficient capacity!” и 
        продължете със следващия ред. На последния ред, изведете литрите в съда.
         */
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());

            short capacity = 255;
            short liters = capacity;

            for (short i = 0; i < n; i++)
            {
                short currentLiters = short.Parse(Console.ReadLine());

                if (liters - currentLiters >= 0)
                {
                    liters -= currentLiters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            short result = (short)(capacity - liters);
            Console.WriteLine(result);
        }
    }
}
