using System;
using System.Collections.Generic;
using System.Linq;

class CODEPhoenix
{
    static void Main()
    {

        Dictionary<string, List<string>> creatureMatesDict = new Dictionary<string, List<string>>();

        string input = Console.ReadLine();

        while (input != "Blaze it!")
        {
            string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            string creature = tokens[0];
            string squadMate = tokens[1];

            if (!creatureMatesDict.ContainsKey(creature))
            {
                creatureMatesDict.Add(creature, new List<string>());
            }
            if (!creatureMatesDict[creature].Contains(squadMate))
            {
                creatureMatesDict[creature].Add(squadMate);
            }

            input = Console.ReadLine();
        }

        Dictionary<string, int> creatureCountDict = new Dictionary<string, int>();

        foreach (var creature in creatureMatesDict)
        {
            int count = creature.Value.Count;
            string currentCreature = creature.Key;
            List<string> mates = creature.Value;

            foreach (var mate in mates)
            {
                if (creatureMatesDict.ContainsKey(mate) && creatureMatesDict[mate].Contains(currentCreature))
                {
                    count--;
                }
            }

            creatureCountDict.Add(creature.Key, count);
        }

        creatureCountDict = creatureCountDict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        foreach (var creature in creatureCountDict)
        {
            Console.WriteLine("{0} : {1}", creature.Key, creature.Value);
        }
    }
}

