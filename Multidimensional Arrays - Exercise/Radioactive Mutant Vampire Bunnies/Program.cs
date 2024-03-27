namespace Radioactive_Mutant_Vampire_Bunnies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fieldSize = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = fieldSize[0];
            int cols = fieldSize[1];
            char[,] lairMatrix = new char[rows, cols];

            var playerPosition = FillLairMatrex(lairMatrix);
            int playerRow = playerPosition.playerRow;
            int playerCol = playerPosition.playerCol;

            char[] commands = Console.ReadLine().ToCharArray();

            bool playerWon = false;
            bool playerDied = false;

            for (int i = 0; i < commands.Length; i++)
            {
                char currentCommand = commands[i];
                var moveResult = PlayerMove(lairMatrix, playerRow, playerCol, currentCommand, playerWon);
                playerRow = moveResult.playerRow;
                playerCol = moveResult.playerCol;
                playerWon = moveResult.playerWon;

                Queue<int[]> bunnies = new Queue<int[]>();
                FindBunnies(lairMatrix, bunnies);

                BunniesSpread(lairMatrix, bunnies);

                if (playerWon)
                {
                    break;
                }

                if (lairMatrix[playerRow, playerCol] == 'B')
                {
                    playerDied = true;
                    break;
                }
            }

            PrintMatrix(lairMatrix);

            if (playerWon)
            {
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }
            else if (playerDied)
            {
                Console.WriteLine($"dead: {playerRow} {playerCol}");
            }

        }

        private static void PrintMatrix(char[,] lairMatrix)
        {
            for (int row = 0; row < lairMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < lairMatrix.GetLength(1); col++)
                {
                    Console.Write(lairMatrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void BunniesSpread(char[,] lairMatrix, Queue<int[]> bunnies)
        {
            while (bunnies.Count > 0)
            {
                int[] currentBunny = bunnies.Dequeue();
                int bunnyRow = currentBunny[0];
                int bunnyCol = currentBunny[1];

                if (bunnyCol > 0)
                {
                    lairMatrix[bunnyRow, bunnyCol - 1] = 'B';
                }
                if (bunnyCol < lairMatrix.GetLength(1) - 1)
                {
                    lairMatrix[bunnyRow, bunnyCol + 1] = 'B';
                }
                if (bunnyRow > 0)
                {
                    lairMatrix[bunnyRow - 1, bunnyCol] = 'B';
                }
                if (bunnyRow < lairMatrix.GetLength(0) - 1)
                {
                    lairMatrix[bunnyRow + 1, bunnyCol] = 'B';
                }
            }
        }

        private static void FindBunnies(char[,] lairMatrix, Queue<int[]> bunnies)
        {
            for (int row = 0; row < lairMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < lairMatrix.GetLength(1); col++)
                {
                    if (lairMatrix[row, col] == 'B')
                    {
                        bunnies.Enqueue(new int[] { row, col });
                    }
                }
            }
        }

        private static (int playerRow, int playerCol, bool playerWon) PlayerMove(char[,] lairMatrix, int playerRow, int playerCol, char currentCommand, bool playerWon)
        {
            lairMatrix[playerRow, playerCol] = '.';

            if (currentCommand == 'L')
            {
                playerCol--;
                if (playerCol < 0)
                {
                    playerWon = true;
                    playerCol++;
                }
            }
            else if (currentCommand == 'R')
            {
                playerCol++;
                if (playerCol >= lairMatrix.GetLength(1))
                {
                    playerWon = true;
                    playerCol--;
                }
            }
            else if (currentCommand == 'U')
            {
                playerRow--;
                if (playerRow < 0)
                {
                    playerWon = true;
                    playerRow++;
                }
            }
            else if (currentCommand == 'D')
            {
                playerRow++;
                if (playerRow >= lairMatrix.GetLength(0))
                {
                    playerWon = true;
                    playerRow--;
                }
            }

            return (playerRow, playerCol, playerWon);
        }

        private static (int playerRow, int playerCol) FillLairMatrex(char[,] lairMatrix)
        {
            int playerRow = 0;
            int playerCol = 0;

            for (int row = 0; row < lairMatrix.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < lairMatrix.GetLength(1); col++)
                {
                    lairMatrix[row, col] = currentRow[col];
                    if (currentRow[col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            return (playerRow, playerCol);
        }
    }
}
