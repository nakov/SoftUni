using System;
using System.Collections.Generic;
using System.Linq;

class PhonebookUpgrade
{
    static void Main()
    {
        var phonebook = new SortedDictionary<string, string>();
        string command = "";
        while (true)
        {
            string[] entry = Console.ReadLine().Split(' ').ToArray();
            command = entry[0];
            if (command == "END")
            {
                break;
            }
            string name = "";
            string phone = "";

            if (entry.Length >= 2)
            {
                name = entry[1];
            }

            if (entry.Length == 3)
            {
                phone = entry[2];
            }

            if (command == "A")
            {
                if (phonebook.ContainsKey(name) && !phonebook.ContainsValue(phone))
                {
                    phonebook.Remove(name);
                    phonebook.Add(name, phone);
                }
                else if (!phonebook.ContainsKey(name) && !phonebook.ContainsValue(phone))
                {
                    phonebook.Add(name, phone);
                }
            }
            else if (command == "S")
            {
                if (!phonebook.ContainsKey(name))
                {
                    Console.WriteLine($"Contact {name} does not exist.");
                }
                else if (phonebook.ContainsKey(name))
                {
                    foreach (var item in phonebook)
                    {
                        if (item.Key == name)
                        {
                            Console.WriteLine($"{item.Key} -> {item.Value}");
                        }
                    }
                }
            }
            else if (command == "ListAll")
            {
                foreach (var item in phonebook)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }

            }

        }
    }
}
