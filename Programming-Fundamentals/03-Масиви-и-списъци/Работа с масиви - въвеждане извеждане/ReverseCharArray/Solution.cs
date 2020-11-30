using System;

namespace ReverseCharArray
{
    /* 
    Напишете програма, която да прочете масив от симовлни низове, обръща масива и печата на неговите елементи. 
    Входът се състои от поредица от низове, разделени с интервал. Отпечатва резултата на един ред с разделител интервал.
    */
    class Solution
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ');
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", arr[i]);
            }
                
        }
    }
}
