using System;

namespace CatchTheThief
{
    /*
    В бъдещето, много опасен крадец е избягал. 
    Вашата мисия е да го хванете, но знаете само типа на неговото числено ID.
    На първи ред, ще получите типа на ID-то на крадеца. На втори ред, ще получите n – броят на ID-та. 
    Човекът, който има ID най-близко до максималната стойност на дадения тип без да го препълва е крадецът.
     */
    class Solution
    {
        static void Main(string[] args)
        {
            string dataTypeThiefID = Console.ReadLine();
            byte countOfIDs = byte.Parse(Console.ReadLine());
            long thiefID = long.MinValue;
            while (countOfIDs > 0)
            {
                string currentID = Console.ReadLine();
                if (dataTypeThiefID == "sbyte")
                {
                    try
                    {
                        long currentIDNum = sbyte.Parse(currentID);
                        thiefID = Math.Max(currentIDNum, thiefID);
                    }
                    catch (Exception)
                    {

                    }
                }
                if (dataTypeThiefID == "int")
                {
                    try
                    {
                        long currentIDNum = int.Parse(currentID);
                        thiefID = Math.Max(currentIDNum, thiefID);
                    }
                    catch (Exception)
                    {

                    }
                }
                if (dataTypeThiefID == "long")
                {
                    try
                    {
                        long currentIDNum = long.Parse(currentID);
                        thiefID = Math.Max(currentIDNum, thiefID);
                    }
                    catch (Exception)
                    {

                    }
                }

                countOfIDs--;
            }

            Console.WriteLine(thiefID);
        }
    }
}
