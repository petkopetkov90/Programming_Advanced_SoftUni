namespace Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[,] matrix = new char[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                char[] chars = Console.ReadLine()
                    .ToCharArray();

                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = chars[col];
                }
            }

            int removedKnights = 0;
            bool knightIsAttacked = true;

            while (knightIsAttacked)
            {
                knightIsAttacked = false;
                int maxAttackKnightRow = -1;
                int maxAttackKnightCol = -1;
                int maxAttacks = 0;

                for (int row = 0; row < matrixSize; row++)
                {
                    for (int col = 0; col < matrixSize; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            int currentAttacks = 0;

                            if (row - 2 >= 0 && col - 1 >= 0 && matrix[row - 2, col - 1] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (row - 2 >= 0 && col + 1 < matrixSize && matrix[row - 2, col + 1] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (row + 2 < matrixSize && col - 1 >= 0 && matrix[row + 2, col - 1] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (row + 2 < matrixSize && col + 1 < matrixSize && matrix[row + 2, col + 1] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (col - 2 >= 0 && row - 1 >= 0 && matrix[row - 1, col - 2] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (col - 2 >= 0 && row + 1 < matrixSize && matrix[row + 1, col - 2] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (col + 2 < matrixSize && row - 1 >= 0 && matrix[row - 1, col + 2] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (col + 2 < matrixSize && row + 1 < matrixSize && matrix[row + 1, col + 2] == 'K')
                            {
                                currentAttacks++;
                            }

                            if (currentAttacks > 0)
                            {
                                knightIsAttacked = true;

                                if (currentAttacks > maxAttacks)
                                {
                                    maxAttacks = currentAttacks;
                                    maxAttackKnightRow = row;
                                    maxAttackKnightCol = col;
                                }
                            }
                        }
                    }
                }

                if (knightIsAttacked)
                {
                    matrix[maxAttackKnightRow, maxAttackKnightCol] = '0';
                    removedKnights++;
                }
            }

            Console.WriteLine(removedKnights);
        }
    }
}