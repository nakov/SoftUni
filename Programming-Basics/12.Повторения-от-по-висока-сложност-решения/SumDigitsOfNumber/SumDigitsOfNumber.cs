using System;

class SumDigitsOfNumber
{
    // 2. Сумиране на цифрите на число
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var sum = 0;
        do
        {
            sum += (n % 10);  // sum = sum + (n%10)
            n /= 10;          // n = n / 10
        }
        while (n > 0);
        Console.WriteLine(sum);
    }
}

