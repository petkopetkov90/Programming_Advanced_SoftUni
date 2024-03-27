
using System.Data;

int[] matrixArea = Console.ReadLine()
    .Split(",", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

char[,] cupboard = new char[matrixArea[0], matrixArea[1]];
int mouseRow = 0;
int mouseCol = 0;
int cheeseCount = 0;

for (int row = 0; row < cupboard.GetLength(0); row++)
{
    char[] currentRow = Console.ReadLine().ToCharArray();

    for (int col = 0; col < cupboard.GetLength(1); col++)
    {
        cupboard[row, col] = currentRow[col];

        if (cupboard[row, col] == 'M')
        {
            mouseRow = row;
            mouseCol = col;
            cupboard[row, col] = '*';
        }

        if (cupboard[row, col] == 'C')
        {
            cheeseCount++;
        }
    }
}

string command;
while ((command = Console.ReadLine()) != "danger")
{
    if (IsOutsideOfCupboard())
    {
        Console.WriteLine("No more cheese for tonight!");
        break;
    }

    else if (HitAWall())
    {
        continue;
    }

    switch (command)
    {
        case "up":
            mouseRow--;
            break;
        case "down":
            mouseRow++;
            break;
        case "right":
            mouseCol++;
            break;
        case "left":
            mouseCol--;
            break;
    }

    if (cupboard[mouseRow, mouseCol] == 'C')
    {
        cheeseCount--;
        cupboard[mouseRow, mouseCol] = '*';

        if (cheeseCount == 0)
        {
            Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
            break;
        }
    }
    else if (cupboard[mouseRow, mouseCol] == 'T')
    {
        Console.WriteLine("Mouse is trapped!");
        break;
    }

}

cupboard[mouseRow, mouseCol] = 'M';

if (command == "danger")
{
    Console.WriteLine("Mouse will come back later!");
}


for (int row = 0; row < cupboard.GetLength(0); row++)
{
    for (int col = 0; col < cupboard.GetLength(1); col++)
    {
        Console.Write(cupboard[row, col]);
    }
    Console.WriteLine();
}

bool HitAWall()
{
    switch (command)
    {
        case "up":
            if (cupboard[mouseRow - 1, mouseCol] == '@')
            {
                return true;
            }
            break;
        case "down":
            if (cupboard[mouseRow + 1, mouseCol] == '@')
            {
                return true;
            }
            break;
        case "right":
            if (cupboard[mouseRow, mouseCol + 1] == '@')
            {
                return true;
            }
            break;
        case "left":
            if (cupboard[mouseRow, mouseCol - 1] == '@')
            {
                return true;
            }
            break;
    }

    return false;
}

bool IsOutsideOfCupboard()
{
    switch (command)
    {
        case "up":
            if (mouseRow - 1 < 0)
            {
                return true;
            }
            break;
        case "down":
            if (mouseRow + 1 >= cupboard.GetLength(0))
            {
                return true;
            }
            break;
        case "right":
            if (mouseCol + 1 >= cupboard.GetLength(1))
            {
                return true;
            }
            break;
        case "left":
            if (mouseCol - 1 < 0)
            {
                return true;
            }
            break;
    }

    return false;
}