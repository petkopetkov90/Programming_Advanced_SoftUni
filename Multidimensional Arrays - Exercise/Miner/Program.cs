namespace Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            string[,] fieldMatrix = new string[fieldSize, fieldSize];

            Queue<string> moveCommands = new Queue<string>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries));

            int minerRow = 0;
            int minerCol = 0;
            int totalCoal = 0;
            int coalCollected = 0;

            for (int row = 0; row < fieldSize; row++)
            {
                string[] currentRow = Console.ReadLine().Split();

                for (int col = 0; col < fieldSize; col++)
                {
                    fieldMatrix[row, col] = currentRow[col];

                    if (currentRow[col] == "s")
                    {
                        minerRow = row;
                        minerCol = col;
                    }
                    if (currentRow[col] == "c")
                    {
                        totalCoal++;
                    }
                }
            }

            bool gameOver = false;
            bool allCoalCollected = false;

            while (moveCommands.Count > 0)
            {
                string currentMove = moveCommands.Dequeue();
                MoveMinerOnField(fieldSize, ref minerRow, ref minerCol, currentMove);

                if (fieldMatrix[minerRow, minerCol] == "e")
                {
                    gameOver = true;
                    break;
                }
                else if (fieldMatrix[minerRow, minerCol] == "c")
                {
                    coalCollected++;
                    fieldMatrix[minerRow, minerCol] = "*";

                    if (coalCollected == totalCoal)
                    {
                        allCoalCollected = true;
                        break;
                    }
                }
            }

            PrintResult(minerRow, minerCol, totalCoal, coalCollected, gameOver, allCoalCollected);

        }

        private static void PrintResult(int minerRow, int minerCol, int totalCoal, int coalCollected, bool gameOver, bool allCoalCollected)
        {
            if (gameOver)
            {
                Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
            }
            else if (allCoalCollected)
            {
                Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
            }
            else
            {
                Console.WriteLine($"{totalCoal - coalCollected} coals left. ({minerRow}, {minerCol})");
            }
        }

        private static void MoveMinerOnField(int fieldSize, ref int minerRow, ref int minerCol, string currentMove)
        {
            if (currentMove == "up" && minerRow > 0)
            {
                minerRow -= 1;
            }
            else if (currentMove == "down" && minerRow < fieldSize - 1)
            {
                minerRow += 1;
            }
            else if (currentMove == "left" && minerCol > 0)
            {
                minerCol -= 1;
            }
            else if (currentMove == "right" && minerCol < fieldSize - 1)
            {
                minerCol += 1;
            }
        }
    }
}
