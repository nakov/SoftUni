using System;
using System.Collections.Generic;
using System.Linq;

class PhonebookCorrection
{
    static void Main()
    {
        var phonebook = new Dictionary<string, string>();
        string input;

        while (!(input = Console.ReadLine()).Contains("stop"))
        {
            string name = input;
            string email = Console.ReadLine();

            phonebook.Add(name, email);
        }

        phonebook = phonebook.Where(x => !x.Value.ToLower().EndsWith("us") && !x.Value.ToLower().EndsWith("uk"))
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var kvp in phonebook)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}

