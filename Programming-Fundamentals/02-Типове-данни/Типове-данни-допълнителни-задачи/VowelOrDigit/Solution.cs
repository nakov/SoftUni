using System;

namespace VowelOrDigit
{
    /*
     Напишете програма, която проверява дали даден символ е цифра, гласна или друг символ.
     */
    class Solution
    {
        static void Main(string[] args)
        {
            var symbol = Console.ReadLine();
            try
            {
                int.Parse(symbol);
                Console.WriteLine("digit");
            }
            catch (Exception)
            {
                char letter = char.Parse(symbol);
                bool isLetterAVowel =
                    letter == 'a' ||
                    letter == 'o' ||
                    letter == 'u' ||
                    letter == 'e' ||
                    letter == 'i';
                Console.WriteLine(isLetterAVowel ? "vowel" : "other");
            }
        }
    }
}
