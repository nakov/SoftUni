using System;
using System.Numerics;
using System.Text;

class AnonymousDownsite
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int securityKey = int.Parse(Console.ReadLine());

        //We will store the sites in a StringBuilder using AppendLine
        //At the end we will just print it
        StringBuilder affectedSites = new StringBuilder();

        //20 digits after the decimal point will fit only in decimal
        //And we are working with MONEY on top of that
        decimal totalLoss = 0M;

        for (int i = 0; i < n; i++)
        {
            string[] siteParameters = Console.ReadLine().Split();

            string siteName = siteParameters[0];
            long siteVisits = long.Parse(siteParameters[1]); //hmm why long ... [0, 2^31]... int range is [-2^31, 2^31 - 1]
            decimal siteCommercialIncomePerVisit = decimal.Parse(siteParameters[2]); //again, money

            affectedSites.AppendLine(siteName); //just add the site here with append line
            totalLoss += siteCommercialIncomePerVisit * siteVisits; //the formula from the problem description
        }

        Console.Write(affectedSites); //Just a simple print
        Console.WriteLine($"Total Loss: {totalLoss:F20}"); //Print and format

        //Third result of search in google "how to power big number C#"
        //Why big number? Let's check the problem description
        //We have to power the security key (which by Constraints has maximum value - 9)
        //We have to power it by the sites count (in other words N, which by Constraints has a maximum value - 100)
        //9^100 ... Sure won't fit in double. So it's a big number.
        Console.WriteLine($"Security Token: {BigInteger.Pow(new BigInteger(securityKey), n)}");
    }
}

