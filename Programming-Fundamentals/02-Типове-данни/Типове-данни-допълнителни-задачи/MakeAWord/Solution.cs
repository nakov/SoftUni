using System;

namespace MakeAWord
{
    /*
     Напишете програма, която комбинира n знака и извежда на един ред комбинацията им.
     */
    class Solution
    {
        static void Main(string[] args)
        {
            byte wordSize = byte.Parse(Console.ReadLine());
            char[] wordLetters = new char[wordSize];

            for (int i = 0; i < wordSize; i++)
            {
                wordLetters[i] = char.Parse(Console.ReadLine());
            }

            string word = new string(wordLetters);
            Console.WriteLine("The word is: {0}", word);
        }
    }
}
