using System;

class MatrixInputOutput
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];

        // Input
        for (int x = 0; x < rows; x++)
            for (int y = 0; y < cols; y++)
            {
                matrix[x, y] = int.Parse(Console.ReadLine());
            }

        // Output
        for (int x = 0; x < rows; x++)
        {
            for (int y = 0; y < cols; y++)
            {
                Console.Write("{0} ", matrix[x, y]);
            }
            Console.WriteLine(); // New Line
        }
    }
}
