using System;
using System.Collections.Generic;

class MinerTask
{
    static void Main()
    {
        Dictionary<string, int> myDict = new Dictionary<string, int>();

        for (int i = 1; ; i++)
        {
            string resource = Console.ReadLine();

            if (resource.Equals("stop"))
            {
                break;
            }

            int quantity = int.Parse(Console.ReadLine());

            //Тук проверява дали съществува такъв key в myDic директроията и ако не го аддва
            if (!myDict.ContainsKey(resource))
            {
                myDict.Add(resource, 0);
            }

            //тук увеличаваме quantity-то на key-a
            myDict[resource] += quantity;
        }

        foreach (var item in myDict)
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
    }
}
