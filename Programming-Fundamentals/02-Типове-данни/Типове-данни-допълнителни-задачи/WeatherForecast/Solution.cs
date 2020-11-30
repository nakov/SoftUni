using System;

namespace WeatherForecast
{
    class Solution
    {
        /*
        Изобретили сте нова технология за прогнозиране на времето, чрез нумерология. Ще получите число, чрез което може да прогнозирате времето утре. Системата работи по следния начин:
        Ако числото се побира в sbyte – времето е¬¬ “Sunny”
        Ако числото се побира в int – времето е “Cloudy”
        Ако числото се побира в long – времето е “Windy”
        Ако числото е с плаваща запетая – времето е “Rainy”
        Винаги извеждайте най-малкия възможен вариант.
         */
        static void Main(string[] args)
        {
            string numberString = Console.ReadLine();
            try
            {
                sbyte.Parse(numberString);
                Console.WriteLine("Sunny");
            }
            catch (Exception)
            {
                try
                {
                    int.Parse(numberString);
                    Console.WriteLine("Cloudy");
                }
                catch (Exception)
                {
                    try
                    {
                        long.Parse(numberString);
                        Console.WriteLine("Windy");
                    }
                    catch (Exception)
                    {
                        try
                        {
                            decimal.Parse(numberString);
                            Console.WriteLine("Rainy");
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
            }
        }
    }
}
