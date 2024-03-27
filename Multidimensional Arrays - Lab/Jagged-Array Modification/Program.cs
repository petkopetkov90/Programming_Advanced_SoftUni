namespace Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[][] matrix = new int[matrixSize][];

            for (int row = 0; row < matrixSize; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            }

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] commandDetails = command.Split();
                string commandType = commandDetails[0];
                int row = int.Parse(commandDetails[1]);
                int col = int.Parse(commandDetails[2]);
                int value = int.Parse(commandDetails[3]);

                if (row < 0 || row >= matrixSize || col < 0 || col >= matrixSize)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (commandType == "Add")
                {
                    matrix[row][col] += value;
                }
                else if (commandType == "Subtract")
                {
                    matrix[row][col] -= value;
                }
            }

            foreach (int[] row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
