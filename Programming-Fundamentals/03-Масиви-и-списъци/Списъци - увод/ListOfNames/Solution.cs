using System;

namespace ListOfNames
{
    /* 
    Въведете списък от имена на хора и го изведете в конзолата в обратен ред. 
    Елементите на списъка ще получите от единствен ред, разделени с интервали. 
    Изведете имената на единствен ред, така че след всяко да стои знак ";".
*/
    class Solution
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(' ');
            Console.WriteLine(String.Join("; ", names));
        }
    }
}
