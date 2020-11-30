using System;

namespace StringConcatenation
{
    /*
    Напишете програма, която въвежда три реда от конзолата. 
    На първи ред ще въведете разделител (char) – трябва да разделите всички низове с този разделител. 
    На втори ред ще получите “even” или “odd”. 
    Ако получите “odd”, трябва да вземете всеки нечетен низ и обратното – ако получите “even”. 
    На последния ред ще получите брой на редовете – n. Първата стъпка от цикъла започва от 1.
    Изведете получения низ на нов ред. 
     */
    class Solution
    {
        static void Main(string[] args)
        {
            string separator = Console.ReadLine();
            byte remainder = Console.ReadLine() == "even" ? (byte)0 : (byte)1;
            byte stringsCount = byte.Parse(Console.ReadLine());
            string concatenatedString = "";

            for (int i = 1; i <= stringsCount; i++)
            {
                if (i % 2 == remainder)
                {
                    concatenatedString += Console.ReadLine() + separator;
                }
                else
                {
                    Console.ReadLine();
                }
            }

            Console.WriteLine(concatenatedString.Remove(concatenatedString.Length - 1));
        }
    }
}
