using System;
using System.Linq;

class MatrixColsMinimum
{
    static void Main()
    {
        // Input
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int col = 0; col < cols; col++)
                matrix[row, col] = line[col];
        }

        // Minimum Matrix
        int[] min = new int[cols];
        for (int col = 0; col < cols; col++)
        {
            min[col] = matrix[0, col];
            for (int row = 0; row < rows; row++)
            {
                if (matrix[row, col] < min[col])
                    min[col] = matrix[row, col];
            }
        }

        // Output
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
                Console.Write("{0, 5}", matrix[row, col]);
            Console.WriteLine();
        }
        for (int col = 0; col < cols; col++)
            Console.Write("{0, 5}", min[col]);
        Console.WriteLine();
    }
}
