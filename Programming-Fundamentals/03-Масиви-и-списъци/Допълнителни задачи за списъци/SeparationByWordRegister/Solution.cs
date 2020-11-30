using System;
using System.Collections.Generic;
using System.Linq;

namespace SeparationByWordRegister
{
    /*
     Въведете text, след което го разделете към думи и ги разпредете в 3 списъка.
    Думи с малки букви като “programming”, “at” и“databases” – съдържащи се само от малки букви.
    Думи с големи букви като “PHP”, “JS” and “SQL” – съдържат само големи букви.
    Смесени думи като “C#”, “CodeCamp” и “Java” – всички други.
    Използвайте следните разделители между думите: , ; : . ! ( ) " ' \ / [ ] интервал
    Изведете трите списъка, както е показано в примера.
     */
    class Solution
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ',', ';', ' ', '.', ':', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var lowerCase = new List<string>();
            var upperCase = new List<string>();
            var mixedCase = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].All(char.IsLower))
                {
                    lowerCase.Add(input[i]);
                }
                else if (input[i].All(char.IsUpper))
                {
                    upperCase.Add(input[i]);
                }
                else
                {
                    mixedCase.Add(input[i]);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
