using System;

namespace LastKNumbersSumsSequence
{
    /*
     Въведете две числа n и k. Създайте и изведете следното множество от  n елемента:
    Първият елемент е : 1
    Всички други елементи са  = сбор от предишните k елемента 
    (ако няма k елемента преди текущия, то да се изведе  сбора на всички до момента)
    Пример: n = 9, k = 5  120 = 4 + 8 + 16 + 31 + 61
     */
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] numbers = new long[n];
            numbers[0] = 1;
            SumLastKNumbers(numbers, k);
        }
        static void SumLastKNumbers(long[] numbers, int k)
        {
            for (int currentElement = 1; currentElement < numbers.Length; currentElement++)
            {
                int startIndex = Math.Max(0, currentElement - k);
                int endIndex = currentElement - 1;
                long sum = 0;
                for (int i = startIndex; i <= endIndex; i++)
                {
                    sum += numbers[i];
                }
                numbers[currentElement] = sum;
            }
            PrintArray(numbers);
        }

        private static void PrintArray(long[] numbers)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
