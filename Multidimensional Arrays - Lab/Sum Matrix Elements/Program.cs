namespace Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];
            int sum = 0;

            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] currentArray = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

                matrix[row] = currentArray;
                sum += currentArray.Sum();
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
