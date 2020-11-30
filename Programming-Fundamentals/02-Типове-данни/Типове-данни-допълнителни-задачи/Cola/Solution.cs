using System;

namespace Cola
{
    /*
    Напишете програма, която изчислява обема на n бурета. 
    Ще въведете общо 3 * n реда. Всеки три реда ще съдържат информация за едно буре. 
    Първият ред е модела на бурето, втория е радиуса му, а третия е височината му.
    Изчислете обема използвайки формулата: π * r^2 * h. 
    Накрая, изведете модела на най-голямото буре.

     */
    class Solution
    {
        static void Main(string[] args)
        {
            byte kegsCount = byte.Parse(Console.ReadLine());
            string biggestKegModel = "";
            double biggestKegVolume = 0;
            float pi = (float)Math.PI;

            while (kegsCount > 0)
            {
                string currentKegModel = Console.ReadLine();
                float kegRadius = float.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());
                double currentVolume = (double)pi * kegRadius * kegRadius * kegHeight;
                if (currentVolume > biggestKegVolume)
                {
                    biggestKegVolume = currentVolume;
                    biggestKegModel = currentKegModel;
                }
                kegsCount--;
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}
