namespace Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = matrixSizes[0];
            int cols = matrixSizes[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int maxSum = int.MinValue;
            int maxSquareRow = 0;
            int maxSquareCol = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxSquareRow = row;
                        maxSquareCol = col;
                    }
                }
            }

            Console.Write(matrix[maxSquareRow, maxSquareCol] + " ");
            Console.WriteLine(matrix[maxSquareRow, maxSquareCol + 1]);
            Console.Write(matrix[maxSquareRow + 1, maxSquareCol] + " ");
            Console.WriteLine(matrix[maxSquareRow + 1, maxSquareCol + 1]);
            Console.WriteLine(maxSum);
        }
    }
}
