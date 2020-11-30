using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    /*
     Напишете програма, която въвежда списък от цели числа от конзолата и получава команди, които манипулират списъка. 
    Вашата програма може да получава следните команди: 
    Delete {елемент} – изтрива всички елементи в списъка, които са равни на дадения елемент
    Insert {елемент} {позиция} – вмъква елемент на дадената позиция
    Програмата трябва да приключва, когато получи команда Odd или Even. 
    Ако програмата получи Odd  извежда всички нечетни числа в списъка отделени с единствен интервал, 
    иначе извеждаме по същия начин всички четни числа.

     */
    class Solution
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                string[] curentCommand = Console.ReadLine().Split(' ').ToArray();

                if (curentCommand[0] == "Odd")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] % 2 != 0)
                        {
                            Console.Write(input[i] + " ");
                        }
                    }
                    break;
                }
                if (curentCommand[0] == "Even")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] % 2 == 0)
                        {
                            Console.Write(input[i] + " ");
                        }
                    }
                    break;
                }
                if (curentCommand[0] == "Delete")
                {
                    int number = int.Parse(curentCommand[1]);
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] == number)
                        {
                            input.Remove(input[i]);
                            i--;
                        }
                    }
                }
                if (curentCommand[0] == "Insert")
                {
                    int number = int.Parse(curentCommand[1]);
                    int position = int.Parse(curentCommand[2]);

                    input.Insert(position, number);
                }
            }
        }
    }
}
