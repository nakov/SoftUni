using System;
using System.Linq;

namespace ListOfNamesII
{
    /* 
    Въведете списък от имена на хора и го изведете в конзолата в обратен ред. 
    Елементите на списъка ще получите от единствен ред, разделени със запетаи. 
    Всеки елемент ще представлява име и фамилия. Изведете имената на всеки човек на отделен ред, 
    като първо трябва да изведете фамилията, след което личното име.
    */
    class Solution
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(',').ToList();
            foreach (var name in names)
            {
                Console.WriteLine(String.Join(" ", name.Split(' ').Reverse()));
            }
        }
    }
}
