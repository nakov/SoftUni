using System;
using System.Linq;

namespace ConvertArrayToNumber
{
    /*
    Напишете програма, която въвежда масив от цели числа и г пребразува чрез сумиране  на съседни двойки елементи, 
    докато се получи едно цяло число. Например, ако имаме 3 елемента {2,10,3},  
    то събираме първите два и вторите два елемента и получаваме {2+10, 10+3} = {12, 13}, 
    после събираме всички съседни елементи и получаваме obtain {12+13} = {25}.
    */
    class Solution
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                         .Split()
                         .Select(int.Parse)
                         .ToArray();

            if (arr.Length == 1)
            {
                Console.WriteLine(arr[0]);
                return;
            }
            else
            {
                while (arr.Length != 1)
                {
                    int[] condensed = new int[arr.Length - 1];
                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        condensed[i] = arr[i] + arr[i + 1];
                    }
                    arr = condensed;

                }

                Console.WriteLine(arr[0]);
            }
        }
    }
}
