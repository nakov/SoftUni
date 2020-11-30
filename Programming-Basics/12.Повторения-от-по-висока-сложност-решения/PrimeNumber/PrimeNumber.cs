using System;

class PrimeNumber
{
    // 3. Проверка за просто число
    static void Main()
    {
        var k = int.Parse(Console.ReadLine());
        var prime = true;
        for (int j = 2; j < k; j++)
            if (k % j == 0)
            {
                prime = false;
                break;
            }
        if (prime && k > 1) Console.WriteLine("Prime");
        else Console.WriteLine("Not Prime");
    }
}

