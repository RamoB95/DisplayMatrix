namespace DisplayMatrix
{
    using System;

    public class MatrixDisplay
    {
        public static void Main(string[] args)
        {
            int[,] matrix = {
            { 0, 1, 1, 1, 1 },
            { 1, 0, 1, 1, 1 },
            { 1, 1, 0, 1, 1 },
            { 1, 1, 1, 0, 1 },
            { 1, 1, 1, 1, 0 }
        };

            // Get the dimensions of the matrix
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Display the matrix
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine(); // Keep the console window open
        }
    }
}