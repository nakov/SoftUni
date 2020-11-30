using System;
using System.Collections.Generic;
using System.Linq;

class PopulationCounter
{
    static void Main()
    {
        Dictionary<string, SortedDictionary<string, long>> totalPopulationInCountry = new Dictionary<string, SortedDictionary<string, long>>();
        string input;
        while ((input = Console.ReadLine()) != "report")
        {

            string[] splitedInput = input?.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string city = splitedInput[0];
            string country = splitedInput[1];
            long populationInCity = long.Parse(splitedInput[2]);

            if (!totalPopulationInCountry.ContainsKey(country))
            {
                totalPopulationInCountry.Add(country, new SortedDictionary<string, long>());
            }
            if (!totalPopulationInCountry[country].ContainsKey(city))
            {
                totalPopulationInCountry[country].Add(city, 0);
            }
            totalPopulationInCountry[country][city] = populationInCity;
        }


        foreach (var item in totalPopulationInCountry.OrderByDescending(x => x.Value.Values.Sum()))
        {
            Console.WriteLine($"{item.Key} (total population: {item.Value.Values.Sum()})");
            foreach (var cities in item.Value.OrderByDescending(c => c.Value))
            {
                Console.WriteLine($"=>{cities.Key}: {cities.Value}");
            }
        }
    }
}
