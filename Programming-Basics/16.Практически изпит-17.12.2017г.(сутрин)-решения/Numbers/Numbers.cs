using System;

class Numbers
{
    //6. Номера
    static void Main()
    {
        string start = Console.ReadLine();
        string end = Console.ReadLine();
        int numbers = int.Parse(Console.ReadLine());

        int numbersCount = 0;

        for (int i = 0; i <= 9; i++)
        {
            if (numbersCount == numbers)
            {
                break;
            }

            for (int j = 0; j <= 9; j++)
            {
                for (int k = 0; k <= 9; k++)
                {
                    for (int l = 0; l <= 9; l++)
                    {
                        int sum = i * k - numbers;
                        if (i + j + k + l == sum)
                        {
                            numbersCount++;
                            if (numbersCount == numbers)
                            {
                                Console.Write($"{start}{i}{j}{k}{l}{end}");
                                Console.WriteLine();
                                return;
                            }
                            Console.Write($"{start}{i}{j}{k}{l}{end} ");
                        }
                    }
                }
            }
        }
    }
}
