using System;
using System.Collections.Generic;
using System.Linq;

class Icarus
{
    static void Main()
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
        int damage = 1;
        int icarusLength = list.Count;
        int currentPosition = int.Parse(Console.ReadLine());
        string command = Console.ReadLine();

        while (command != "Supernova")
        {
            List<string> commandsTokens = command.Split(' ').ToList();
            string direction = commandsTokens[0];
            int steps = int.Parse(commandsTokens[1]);

            if (direction == "left")
            {
                if (currentPosition - steps < 0)
                {
                    int counter = steps; while (currentPosition >= 0)
                    {
                        if (currentPosition == 0)
                        {
                            currentPosition = icarusLength;
                            damage++;
                        }
                        currentPosition--;
                        list[currentPosition] -= damage;
                        counter--;

                        if (currentPosition == 0 && counter > 0)
                        {
                            currentPosition = icarusLength;
                            damage++;
                        }
                        if (counter == 0)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    int counter = steps;
                    while (counter > 0)
                    {
                        currentPosition--;
                        list[currentPosition] -= damage;
                        counter--;
                    }
                }
            }
            else if (direction == "right")
            {
                if (currentPosition + steps > icarusLength - 1)
                {
                    int counter = steps;

                    while (currentPosition <= icarusLength - 1)
                    {
                        if (currentPosition == icarusLength - 1)
                        {
                            currentPosition = -1;
                            damage++;
                        }
                        currentPosition++;
                        list[currentPosition] -= damage;
                        counter--;

                        if (currentPosition == icarusLength - 1 && counter > 0)
                        {
                            currentPosition = -1;
                            damage++;
                        }
                        if (counter == 0)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    int counter = steps;
                    while (counter > 0)
                    {
                        currentPosition++;
                        list[currentPosition] -= damage;
                        counter--;
                    }
                }
            }
            command = Console.ReadLine();
        }
        Console.WriteLine(string.Join(" ", list));
    }
}


