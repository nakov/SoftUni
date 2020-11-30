using System;

class CodeGenerator
{
    //6. Генериране на кодове
    static void Main()
    {
        int password = int.Parse(Console.ReadLine());
        int codesNumber = int.Parse(Console.ReadLine());

        int count = 0;

        for (int i = 0; i <= 9; i++)
        {
            for (int j = 0; j <= 9; j++)
            {
                for (int k = 0; k <= 9; k++)
                {
                    for (char l = 'a'; l <= 'z'; l++)
                    {
                        for (char m = 'a'; m <= 'z'; m++)
                        {
                            for (int n = 0; n <= 9; n++)
                            {
                                if (i + j + k + l + m + n == password)
                                {
                                    Console.Write("" + i + j + k + l + m + n + " ");
                                    count++;
                                }

                                if (count == codesNumber)
                                {
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

