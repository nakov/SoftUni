using System;

namespace IndexOfLetters
{
    /* 
    Напишете програма, която създава масив, съдържащ всички букви от английската азбука (a-z). 
    Въведете дума с малки букви (lowercase) от конзолата и 
    изведете съответния индекс на всяка буква от масива с буквите от английската азбука.
    */
    class Solution
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            foreach (var item in line)
            {
                Console.WriteLine("{0} -> {1}", item, (int)item - 97);
            }

        }
    }
}
