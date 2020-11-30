using System;

class Garage
{
    //5. Гараж
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int height = n + 2;
        int length = 2 * n + 2;

        string firstLine = new String('|', 2 * n + 2);
        Console.WriteLine(firstLine);

        string secondLine = new String('+', 2 * n + 2);
        Console.WriteLine(secondLine);

        string thirdLine = new String('|', (2 * n + 2 - 6) / 2)
            + "GARAGE" + new String('|', (2 * n + 2 - 6) / 2);
        Console.WriteLine(thirdLine);

        int entranceHeight = 0;
        if (height - 4 == 1)
        {
            entranceHeight = 1;
        }
        else
        {
            entranceHeight = 2;
        }

        int pipeLines = height - 4 - entranceHeight;

        for (int i = 0; i < pipeLines; i++)
        {
            Console.WriteLine(new String('|', 2 * n + 2));
        }

        for (int i = 0; i < entranceHeight; i++)
        {
            int slashesCount = (length - 4 - 4) / 2;
            Console.WriteLine($"|{new String('/', slashesCount)}|    |{new String('\\', slashesCount)}|");
        }

        string lastLine = new String(' ', (int)((length - 5) / 2))
            + "/////" + new String(' ', (int)((length - 5) / 2) - 1);
        Console.WriteLine(lastLine);
    }
}
