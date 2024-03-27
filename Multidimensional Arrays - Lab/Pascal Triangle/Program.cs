namespace Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pascalSize = int.Parse(Console.ReadLine());

            long[][] pascalMatrix = new long[pascalSize][];

            for (int row = 0; row < pascalSize; row++)
            {
                pascalMatrix[row] = new long[row + 1];

                for (int col = 0; col < row + 1; col++)
                {
                    if (col == 0 || col == row)
                    {
                        pascalMatrix[row][col] = 1;
                    }
                    else
                    {
                        pascalMatrix[row][col] = pascalMatrix[row - 1][col] + pascalMatrix[row - 1][col - 1];
                    }
                }
            }

            foreach (long[] row in pascalMatrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
