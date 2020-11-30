using System;
using System.Collections.Generic;
using System.Linq;

class UserLogs
{
    static void Main()
    {
        SortedDictionary<string, List<string>> users = new SortedDictionary<string, List<string>>();
        string command = "";
        while (true)
        {
            List<string> entry = Console.ReadLine().Split().ToList();
            command = entry[0];
            if (command == "end") break;
            int indexOfIP = command.IndexOf('=') + 1;
            string ip = command.Substring(indexOfIP);
            int indexOfUser = entry[2].LastIndexOf('=') + 1;
            string user = entry[2].Substring(indexOfUser);
            List<string> IPs = new List<string>();
            IPs.Add(ip);
            if (!users.ContainsKey(user))
            {
                users[user] = IPs;
            }
            else
            {
                users[user].AddRange(IPs);
            }
        }

        foreach (var user in users)
        {
            Console.WriteLine(user.Key + ": ");
            List<string> IPs = user.Value;
            Dictionary<string, int> numberOfIPs = new Dictionary<string, int>();
            foreach (var ip in IPs)
            {
                if (!numberOfIPs.ContainsKey(ip))
                {
                    numberOfIPs[ip] = 1;
                }
                else
                {
                    numberOfIPs[ip] += 1;
                }
            }

            int count = numberOfIPs.Count;
            foreach (var ip in numberOfIPs)
            {
                count--;
                if (count > 0)
                {
                    Console.Write(ip.Key + " => " + ip.Value + ", ");
                }
                else
                {
                    Console.Write(ip.Key + " => " + ip.Value + ". ");
                }
            }
            Console.WriteLine();

        }
    }
}