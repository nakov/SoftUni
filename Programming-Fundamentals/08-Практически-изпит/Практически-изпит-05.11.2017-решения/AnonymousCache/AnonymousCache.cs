using System;
using System.Collections.Generic;
using System.Linq;

class AnonymousCache
{
    static void Main()
    {
        //The Dictionary problem. How do we solve it without Classes.
        //We have to have an actual data and some cache data. Well ... Let's just make 2 identical dictionaries.
        Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
        Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();

        string inputLine = string.Empty;

        //Another cool way to make a "Read Until" While loop
        while ((inputLine = Console.ReadLine()) != "thetinggoesskrra")
        {
            //Just split the input
            string[] inputParameters =
                inputLine.Split(new[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries);

            //If we are adding a dataSet
            if (inputParameters.Length == 1)
            {
                string dataSet = inputParameters[0];

                //If the cache contains the dataSet, we add all of the dataKeys and dataSizes from the cache to the actual data
                if (cache.ContainsKey(dataSet))
                {
                    data[dataSet] = new Dictionary<string, long>(cache[dataSet]);
                    cache.Remove(dataSet);
                }
                else
                {
                    //Else we just initialize an empty one
                    data[dataSet] = new Dictionary<string, long>();
                }
            }
            else
            {
                string dataKey = inputParameters[0];
                long dataSize = long.Parse(inputParameters[1]);
                string dataSet = inputParameters[2];

                //If the data does not contain such a dataSet we add it to the cache
                if (!data.ContainsKey(dataSet))
                {
                    //If the cache does not contain such a dataSet, we initialize the inner dictionary
                    //Otherwise we get null reference exception
                    if (!cache.ContainsKey(dataSet))
                    {
                        cache[dataSet] = new Dictionary<string, long>();
                    }

                    //Then we just add the key and size to the cache
                    cache[dataSet][dataKey] = dataSize;
                }
                else
                {
                    //If the data contains such a dataSet, we just add the key and the size to it
                    data[dataSet][dataKey] = dataSize;
                }
            }
        }

        //If no data is found .First() will return Exception.
        //It was written in the Problem Description that we need to DO NOTHING
        if (data.Count > 0)
        {
            //Get the first result
            //Now here it gets funny
            //You wondered why we have long in our dictionary?
            //By constraint the value is [0, 1.000.000.000]. And int max value is > 2.000.000.000
            //But we have to sum them ... What happens when we sum 3 * 1.000.000.000?
            KeyValuePair<string, Dictionary<string, long>> result = data
                .OrderByDescending(ds => ds.Value.Sum(d => d.Value)) //SUMMING EVERYTHING
                .First();

            //Just a simple print
            Console.WriteLine($"Data Set: {result.Key}, Total Size: {result.Value.Sum(d => d.Value)}");

            //Let's extract the prefix in a variable
            string prefix = "$.";

            foreach (var value in result.Value)
            {
                //Just printing
                Console.WriteLine($"{prefix}{value.Key}");
            }
        }
    }
}

