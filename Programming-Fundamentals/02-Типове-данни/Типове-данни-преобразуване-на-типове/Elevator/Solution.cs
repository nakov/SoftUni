using System;

namespace Elevator
{
    /* 12.	Асансьор
    Изчислете колко курса ще трябва да направя един асансьор, за да се качат n човека,  ако капацитета на асансьора е p човека. 
    Входа се състои от два реда: броя на хората n и капацитета p на асансьора.
    */
    class Solution
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)n / p);
            Console.WriteLine(courses);
            string Pause = Console.ReadLine();
        }
    }
}
