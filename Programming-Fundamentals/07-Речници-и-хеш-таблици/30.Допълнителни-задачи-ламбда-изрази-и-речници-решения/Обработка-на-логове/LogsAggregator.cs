using System;
using System.Linq;
using System.Collections.Generic;

class LogsAggregator
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        SortedDictionary<string, SortedDictionary<string, int>> log = new SortedDictionary<string, SortedDictionary<string, int>>();
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string user = input[1];
            string ip = input[0];
            int duration = int.Parse(input[2]);
            if (!log.ContainsKey(user))
            {
                log.Add(user, new SortedDictionary<string, int>());
            }
            if (!log[user].ContainsKey(ip))
            {
                log[user].Add(ip, 0);
            }
            log[user][ip] += duration;
        }
        foreach (var item in log.OrderBy(x => x.Key))
        {
            int durationSum = item.Value.Sum(x => x.Value);
            Console.Write($"{item.Key}: {durationSum} ");
            List<string> ips = new List<string>();
            foreach (var element in item.Value.OrderBy(x => x.Key))
            {
                ips.Add(element.Key);
            }
            Console.WriteLine($"[{string.Join(", ", ips)}] ");
        }
    }
}
