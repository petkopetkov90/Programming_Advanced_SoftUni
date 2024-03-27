namespace Snake_Moves
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
            char[] snake = Console.ReadLine().ToCharArray();
            int matrixFields = rows * cols;

            Queue<char> snakeQueue = new Queue<char>();

            while (snakeQueue.Count < matrixFields)
            {
                for (int i = 0; i < snake.Length; i++)
                {
                    snakeQueue.Enqueue(snake[i]);
                    if (snakeQueue.Count == matrixFields)
                    {
                        break;
                    }
                }
            }

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row % 2 == 0)
                    {
                        matrix[row, col] = snakeQueue.Dequeue();
                    }
                    else
                    {
                        matrix[row, cols - 1 - col] = snakeQueue.Dequeue();
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
