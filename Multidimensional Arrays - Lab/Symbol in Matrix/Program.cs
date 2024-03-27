namespace Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[,] matrix = new char[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            bool containsSymbol = false;

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        containsSymbol = true;
                        break;
                    }
                }
                if(containsSymbol)
                {
                    break;
                }
            }

            if (!containsSymbol)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
