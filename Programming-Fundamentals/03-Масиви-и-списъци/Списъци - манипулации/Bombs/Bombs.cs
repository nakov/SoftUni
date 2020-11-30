using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    /*
     Напишете програма, която въвежда поредица от числа и специално число - бомбичка с определена сила. 
    Вашата задача е да детонирате всяко срещане на специалното число бомба и според нейната сила нейните съседи отляво и отдясно. 
    Детонациите се изпълняват отляво надясно и всички детонирани числа изчезват. 
    Най-накрая изведете сумата от оставащите елементи в поредицата.
    */
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> bombPower = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < number.Count; i++)
            {
                if (number[i] == bombPower[0])
                {
                    for (int j = 1; j <= bombPower[1]; j++)
                    {
                        if (i - j < 0)
                        {
                            break;
                        }
                        else
                        {
                            number[i - j] = 0;
                        }
                    }

                    for (int j = 1; j <= bombPower[1]; j++)
                    {
                        if (i + j > number.Count - 1)
                        {
                            break;
                        }
                        else
                        {
                            number[i + j] = 0;
                        }
                    }

                    number[i] = 0;
                }

            }

            int sum = number.Sum();
            Console.WriteLine(sum);
        }
    }
}
