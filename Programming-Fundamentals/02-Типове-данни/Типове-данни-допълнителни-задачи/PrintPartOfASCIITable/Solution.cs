using System;

namespace PrintPartOfASCIITable
{
    /*
    Намерете в Интернет повече информация за ASCII (American Standard Code for Information Interchange) 
    и напишете програма, която извежда част от ASCII таблицата от знаци на конзолата.  
    На първи ред на входа ще получите индекса на знака, от който трябва да започнете, 
    а на втория ред – индекса на последния знак.
   */
    class Solution
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int stopNumber = int.Parse(Console.ReadLine());

            for (int i = startNumber; i <= stopNumber; i++)
            {
                Console.Write((char)i + " ");

            }
            Console.WriteLine();
        }
    }
}
