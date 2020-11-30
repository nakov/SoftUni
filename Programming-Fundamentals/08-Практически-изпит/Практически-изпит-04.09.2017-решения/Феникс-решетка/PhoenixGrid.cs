using System;
using System.Text.RegularExpressions;

class PhoenixGrid
{
    static void Main()
    {
        Regex pattern = new Regex(@"^([^\s_]{3})(\.[^\s_]{3})*$");


        string input = Console.ReadLine().Trim();

        while (input != "ReadMe")
        {
            char[] inputArray = input.ToCharArray();
            Array.Reverse(inputArray);
            string revercedImput = string.Join("", inputArray);

            if (input == revercedImput && pattern.IsMatch(input))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            input = Console.ReadLine();
        }
    }
}

