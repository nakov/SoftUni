using System;
using System.Collections.Generic;

class ImmuneSystem
{
    static void Main()
    {
        int initialHealth = int.Parse(Console.ReadLine());
        Dictionary<string, int> viruses = new Dictionary<string, int>();
        int currentHealth = initialHealth;

        while (true)
        {
            string virus = Console.ReadLine();
            if (virus == "end")
            {
                break;
            }

            int virusStrength = 0;

            for (int i = 0; i < virus.Length; i++)
            {
                virusStrength += (int)virus[i];
            }

            virusStrength /= 3;

            int timeToDefeatVirus = virusStrength * virus.Length;

            if (viruses.ContainsKey(virus))
            {
                if (viruses[virus] == 1)
                {
                    timeToDefeatVirus /= 3;
                    viruses[virus] = 2;
                }
            }
            else
            {
                viruses.Add(virus, 1);
            }

            Console.WriteLine($"Virus {virus}: {virusStrength} => {timeToDefeatVirus} seconds");
            if (currentHealth < timeToDefeatVirus)
            {
                Console.WriteLine("Immune System Defeated.");
                return;
            }
            else
            {
                Console.WriteLine($"{virus} defeated in {timeToDefeatVirus / 60}m {timeToDefeatVirus % 60}s.");
            }

            currentHealth -= timeToDefeatVirus;
            Console.WriteLine($"Remaining health: {currentHealth}");
            currentHealth += currentHealth * 2 / 10;
            if (currentHealth > initialHealth)
            {
                currentHealth = initialHealth;
            }
        }

        Console.WriteLine($"Final Health: {currentHealth}");
    }
}
