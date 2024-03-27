namespace Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            long[][] jaggedMatrix = new long[rows][];

            for (int row = 0; row < rows; row++)
            {
                jaggedMatrix[row] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();
            }

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < Math.Max(jaggedMatrix[row].Length, jaggedMatrix[row + 1].Length); col++)
                {
                    if (jaggedMatrix[row].Length == jaggedMatrix[row + 1].Length)
                    {
                        if (jaggedMatrix[row].Length > col)
                        {
                            jaggedMatrix[row][col] = jaggedMatrix[row][col] * 2;
                        }
                        if (jaggedMatrix[row + 1].Length > col)
                        {
                            jaggedMatrix[row + 1][col] = jaggedMatrix[row + 1][col] * 2;
                        }
                    }
                    else
                    {
                        if (jaggedMatrix[row].Length > col)
                        {
                            jaggedMatrix[row][col] = jaggedMatrix[row][col] / 2;
                        }
                        if (jaggedMatrix[row + 1].Length > col)
                        {
                            jaggedMatrix[row + 1][col] = jaggedMatrix[row + 1][col] / 2;
                        }
                    }
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string commandType = command[0];
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                long value = long.Parse(command[3]);

                if (row >= 0 && row < rows && col >= 0 && col < jaggedMatrix[row].Length)
                {
                    if (commandType == "Add")
                    {
                        jaggedMatrix[row][col] += value;
                    }
                    else if (commandType == "Subtract")
                    {
                        jaggedMatrix[row][col] -= value;
                    }
                }
            }

            foreach (long[] row in jaggedMatrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
