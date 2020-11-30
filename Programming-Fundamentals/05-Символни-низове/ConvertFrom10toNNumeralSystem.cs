using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        private static string NumberinNthSystem(int numsys, int number)
        {
            string newNumber = "";
            while (number != 0)
            {
                newNumber += number % numsys;
                number /= numsys;
            }
            newNumber = string.Join("", newNumber.Reverse());
            return newNumber;
        }
      
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numsys = input[0];
            int number = input[1];
            Console.WriteLine(NumberinNthSystem(numsys, number));
        }
    }
}
