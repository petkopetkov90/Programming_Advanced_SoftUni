namespace Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matixSize = int.Parse(Console.ReadLine());
            int[][] matrix = new int[matixSize][];
            int sumOfDiagonal = 0;

            for (int row = 0; row < matixSize; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                sumOfDiagonal += matrix[row][row];
            }

            Console.WriteLine(sumOfDiagonal);

            //int matixSize = int.Parse(Console.ReadLine());
            //int[,] matrix = new int[matixSize, matixSize];
            //int sumOfDiagonal = 0;

            //for (int row = 0; row < matixSize; row++)
            //{
            //    int[] currentRow = Console.ReadLine()
            //        .Split()
            //        .Select(int.Parse)
            //        .ToArray();

            //    for (int col = 0; col < matixSize; col++)
            //    {
            //        matrix[row, col] = currentRow[col];
            //        if (row == col)
            //        {
            //            sumOfDiagonal += currentRow[col];
            //        }
            //    }
            //}

            //Console.WriteLine(sumOfDiagonal);
        }
    }
}
