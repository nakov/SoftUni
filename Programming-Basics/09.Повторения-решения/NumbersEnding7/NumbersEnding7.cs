using System;

class NumbersEnding7
{
    //2.Числа от 1 до 1000 завършващи на 7
    static void Main()
    {
        for (int k = 0; k < 1000; k++)
        {
            if (k % 10 == 7)
            {
                Console.Write(k + " ");
            }
        }
    }
}

