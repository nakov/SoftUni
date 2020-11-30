using System;
using System.Linq;

namespace SearchForNumber
{
    /*
     На първия ред се въвежда списък от цели числа. 
    На следващия ред, ще получите списък с точно три числа. 
    Първото от тях показва броя на елементите, които трябва да вземете от списъка (считано от първия елемент). 
    Второто число показва броя на елементите, които трябва да изтриете от елементите, които взехте 
    (считано от първия елемент). Последното число е това, което търсим в получения списък след манипулациите. 
    Ако това число е в списъка, извеждаме: “YES!”, в противен случай “NO!”
     */
    class Solution
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var comands = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            bool isOK = true;
            int start = comands[1];
            int end = comands[0];

            for (int i = start; i < end; i++)
            {
                if (input[i] == comands[2])
                {
                    Console.WriteLine("YES!");
                    isOK = false;
                }
            }
            if (isOK)
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
