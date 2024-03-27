using System.Numerics;

namespace Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] currentRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                if (!IsValidCommand(command, rows, cols))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int row1 = int.Parse(command[1]);
                int col1 = int.Parse(command[2]);
                int row2 = int.Parse(command[3]);
                int col2 = int.Parse(command[4]);

                string firstElement = matrix[row1, col1];
                string secondElement = matrix[row2, col2];

                matrix[row1, col1] = secondElement;
                matrix[row2, col2] = firstElement;

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }

                    Console.WriteLine();
                }
            }
        }

        private static bool IsValidCommand(string[] command, int rows, int cols)
        {

            if (command.Length != 5 || command[0] != "swap")
            {
                return false;
            }

            int row1 = int.Parse(command[1]);
            int col1 = int.Parse(command[2]);
            int row2 = int.Parse(command[3]);
            int col2 = int.Parse(command[4]);

            if (row1 < 0 || row1 >= rows
                || col1 < 0 || col1 >= cols
                || row2 < 0 || row2 >= rows
                || col2 < 0 || col2 >= cols)
            {
                return false;
            }

            return true;
        }
    }
}
