using System;
using System.Collections.Generic;
using System.Linq;

class PhoneBook
{
    static void Main()
    {
        string command = Console.ReadLine(); // read the command

        Dictionary<string, string> phonebook = new Dictionary<string, string>(); // make a dictionary for the phonebook


        while (command != "END") // check 
        {
            string[] splitedCommands = command.Split(' ').ToArray(); // split the commands

            if (splitedCommands[0] == "S")
            {
                if (!phonebook.ContainsKey(splitedCommands[1]))
                {
                    Console.WriteLine("Contact {0} does not exist.", splitedCommands[1]);
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", splitedCommands[1], phonebook[splitedCommands[1]]);
                }
            }
            else
            {
                phonebook[splitedCommands[1]] = splitedCommands[2];
            }

            command = Console.ReadLine(); // read the command again
        }
    }
}