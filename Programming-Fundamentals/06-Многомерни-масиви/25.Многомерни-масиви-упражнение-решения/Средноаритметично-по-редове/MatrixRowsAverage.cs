using System;

class MatrixRowsAverage
{
    static void Main()
    {
        // Input
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];

        for (int x = 0; x < rows; x++)
            for (int y = 0; y < cols; y++)
                matrix[x, y] = int.Parse(Console.ReadLine());


        // Math & Output
        for (int row = 0; row < rows; row++)
        {
            double avg = 0;
            for (int col = 0; col < cols; col++)
            {
                Console.Write("{0, 10}", matrix[row, col]);
                avg += matrix[row, col];
            }
            avg = avg / cols;
            Console.WriteLine("{0, 10}", avg);
        }

    }
}
