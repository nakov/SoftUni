using System;

class EvenNumberWithCheck
{
    // 4. Въвеждане на четно число 
    static void Main()
    {
        while (true)
        {
            try
            {
                var n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine("Even number entered: " + n);
                    break;
                }
                else Console.WriteLine("The number is not even.");
            }
            catch
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}

