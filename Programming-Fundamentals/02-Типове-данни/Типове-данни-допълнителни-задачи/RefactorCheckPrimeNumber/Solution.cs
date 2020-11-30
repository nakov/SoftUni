using System;

namespace RefactorCheckPrimeNumber
{
    /*
    Получавате код, който проверява дали числата в даден интервал [2...N] са прости. 
    За всяко число изведете "{number} -> {True or False}". 
    Кодът, все пак не е добре написан. Вашата работа е да го подобрите, така че да е лесен за четене и разбиране.
     */
    class Solution
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            for (int currentNumber = 2; currentNumber <= numbersCount; currentNumber++)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(currentNumber); i++)
                {
                    if (currentNumber % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNumber} -> {isPrime}");
            }
        }
    }
}
