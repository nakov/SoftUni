using System;
using System.Linq;

namespace ExtractMiddle1_2or3_Elements
{
    /*
     Напишете метод за извличане на средните 1,2 или 3 елемента от масив от цели числа и изведете резултата на конзолата
    n = 1 -> 1 елемент
    за четно n -> 2 елемента
    за нечетно n -> 3 елемента
    Създайте програма, която чете масив от цели числа (разделени с интервал) и отпечатва средните елементи 
    във формата показан в примерите 
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int len = nums.Length;

            // Take 1,2 or 3
            if (len == 1) nums = nums.Take(1).ToArray();
            else if (len % 2 == 0) nums = nums.Skip(len / 2 - 1).Take(2).ToArray();
            else nums = nums.Skip(len / 2 - 1).Take(3).ToArray();

            Console.WriteLine("{" + $" { string.Join(", ", nums)} " + "}");
        }

    }
}
