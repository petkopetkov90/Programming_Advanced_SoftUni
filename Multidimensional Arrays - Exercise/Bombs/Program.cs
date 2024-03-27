namespace Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            if (matrixSize > 0)
            {
                string[] bombs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                for (int count = 0; count < bombs.Length; count++)
                {
                    string[] currentBomb = bombs[count].Split(",", StringSplitOptions.RemoveEmptyEntries);
                    int bombRow = int.Parse(currentBomb[0]);
                    int bombCol = int.Parse(currentBomb[1]);

                    ExplodingCellsInMatrix(matrix, bombRow, bombCol);
                }
            }

            int aliveCells = 0;
            int sum = 0;

            foreach (int cell in matrix)
            {
                if (cell > 0)
                {
                    aliveCells++;
                    sum += cell;
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if (col == matrixSize - 1)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    else
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static void ExplodingCellsInMatrix(int[,] matrix, int bombRow, int bombCol)
        {
            if (matrix[bombRow, bombCol] < 1)
            {
                return;
            }

            int bombPower = matrix[bombRow, bombCol];
            matrix[bombRow, bombCol] = 0;

            for (int row = bombRow - 1; row <= bombRow + 1; row++)
            {
                for (int col = bombCol - 1; col <= bombCol + 1; col++)
                {
                    if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
                    {
                        if (matrix[row, col] <= 0)
                        {
                            continue;
                        }
                        matrix[row, col] -= bombPower;
                    }

                }
            }
        }
    }
}