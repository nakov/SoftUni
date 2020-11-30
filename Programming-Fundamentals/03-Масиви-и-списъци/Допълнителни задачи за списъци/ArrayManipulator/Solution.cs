using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    /*
     Напишете програма, която въвежда списък от цели числа от конзолата и списък от команди, които се изпълняват върху списъка. 
    Командите са както следва:
    add <индекс> <елемент> – вмъква елемент на зададената позиция (елементите надясно от тази позиция включително се изместват надясно).
    addMany <индекс> <елемент 1> <елемент 2> … <елемент n> – добавя множество от елементи на дадената позиция.
    contains <елемент> – отпечатва индекса на първото срещане на зададения елемент (ако съществува) в списъка или -1, ако елемента не е открит.
    remove <индекс> – премахва елемента, намиращ се на зададената позиция
    shift <позиции> – отмества всеки елемент от списъка съответния брой позиции наляво (с ротация).
    Например, [1, 2, 3, 4, 5] -> shift 2 -> [3, 4, 5, 1, 2]
    sumPairs – сумира елементите на всички двойки в списъка (първа + втора, трета + четвърта, …).
    Например, [1, 2, 4, 5, 6, 7, 8] -> [3, 9, 13, 8].
    print – спира да получава повече команди и извежда последното състояние на списъка.
     */
    class Solution
    {
        static void Main(string[] args)
        {
            List<long> list = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "print")
            {
                string[] tokens = command.Split(' ');
                switch (tokens[0])
                {
                    case "add":
                        int index = int.Parse(tokens[1]);
                        long element = long.Parse(tokens[2]);
                        list.Insert(index, element);
                        break;

                    case "addMany":
                        int index2 = int.Parse(tokens[1]);
                        List<long> elementsToAdd = tokens.Skip(2).Select(long.Parse).ToList();
                        list.InsertRange(index2, elementsToAdd);
                        break;

                    case "contains":
                        long element2 = long.Parse(tokens[1]);
                        Console.WriteLine(list.IndexOf(element2));
                        break;

                    case "remove":
                        int index3 = int.Parse(tokens[1]);
                        list.RemoveAt(index3);
                        break;

                    case "shift":
                        int positions = int.Parse(tokens[1]);
                        for (int i = 0; i < positions; i++)
                        {
                            long lastElement = list[0];
                            for (int j = 0; j < list.Count - 1; j++)
                            {
                                list[j] = list[j + 1];
                            }
                            list[list.Count - 1] = lastElement;
                        }
                        break;

                    case "sumPairs":
                        List<long> newList = new List<long>();
                        for (int i = 0; i < list.Count - 1; i += 2)
                        {
                            newList.Add(list[i] + list[i + 1]);
                        }
                        if (list.Count % 2 == 1)
                        {
                            newList.Add(list[list.Count - 1]);
                        }
                        list = newList;
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", list) + "]");
        }
    }
}
