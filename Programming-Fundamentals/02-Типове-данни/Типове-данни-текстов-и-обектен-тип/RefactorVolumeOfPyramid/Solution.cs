using System;

namespace RefactorVolumeOfPyramid
{
    /* 21. Рефакторирайте Обем на пирамида 
    Получавате работещ код, който намира обема на пирамида. 
    Въпреки това, трябва да вземете предвид неговото качество – дали променливите са именувани разумно, дали се използват най-подходящите типове, 
    какъв е техния промеждутък и дали се използват само за едно дейстиве. 
    */
    class Solution
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            double volume = (length * width * height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);

        }
    }
}
