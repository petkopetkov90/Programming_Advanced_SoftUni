
int[] fieldSizes = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

char[,] neighborhood = new char[fieldSizes[0], fieldSizes[1]];

int deliveryBoyStartRow = 0;
int deliveryBoyStartCol = 0;
int deliveryBoyRow = 0;
int deliveryBoyCol = 0;

for (int row = 0; row < fieldSizes[0]; row++)
{
    string currentRow = Console.ReadLine();

    for (int col = 0; col < fieldSizes[1]; col++)
    {
        neighborhood[row, col] = currentRow[col];

        if (neighborhood[row, col] == 'B')
        {
            deliveryBoyStartRow = row;
            deliveryBoyStartCol = col;
            deliveryBoyRow = row;
            deliveryBoyCol = col;
            neighborhood[row, col] = ' ';
        }
    }
}


bool pizzaIsCollected = false;
bool outOfNeighborhood = false;

while (true)
{
    string command = Console.ReadLine();

    if (command == "up")
    {
        if (deliveryBoyRow - 1 < 0)
        {
            Console.WriteLine("The delivery is late. Order is canceled.");
            outOfNeighborhood = true;
            break;
        }

        if (neighborhood[deliveryBoyRow - 1, deliveryBoyCol] == '*')
        {
            continue;
        }

        deliveryBoyRow--;

        if (MovePossitions())
        {
            Console.WriteLine("Pizza is delivered on time! Next order...");
            break;
        }

    }
    else if (command == "down")
    {
        if (deliveryBoyRow + 1 >= neighborhood.GetLength(0))
        {
            Console.WriteLine("The delivery is late. Order is canceled.");
            outOfNeighborhood = true;
            break;
        }

        if (neighborhood[deliveryBoyRow + 1, deliveryBoyCol] == '*')
        {
            continue;
        }

        deliveryBoyRow++;

        if (MovePossitions())
        {
            Console.WriteLine("Pizza is delivered on time! Next order...");
            break;
        }

    }
    else if (command == "right")
    {
        if (deliveryBoyCol + 1 >= neighborhood.GetLength(1))
        {
            Console.WriteLine("The delivery is late. Order is canceled.");
            outOfNeighborhood = true;
            break;
        }

        if (neighborhood[deliveryBoyRow, deliveryBoyCol + 1] == '*')
        {
            continue;
        }

        deliveryBoyCol++;

        if (MovePossitions())
        {
            Console.WriteLine("Pizza is delivered on time! Next order...");
            break;
        }

    }
    else if (command == "left")
    {
        if (deliveryBoyCol - 1 < 0)
        {
            Console.WriteLine("The delivery is late. Order is canceled.");
            outOfNeighborhood = true;
            break;
        }

        if (neighborhood[deliveryBoyRow, deliveryBoyCol - 1] == '*')
        {
            continue;
        }

        deliveryBoyCol--;

        if (MovePossitions())
        {
            Console.WriteLine("Pizza is delivered on time! Next order...");
            break;
        }
    }
}

if (!outOfNeighborhood)
{
    neighborhood[deliveryBoyStartRow, deliveryBoyStartRow] = 'B';
}

for (int row = 0; row < neighborhood.GetLength(0); row++)
{
    for (int col = 0; col < neighborhood.GetLength(1); col++)
    {
        Console.Write(neighborhood[row, col]);
    }

    Console.WriteLine();
}

bool MovePossitions()
{
    if (neighborhood[deliveryBoyRow, deliveryBoyCol] == '-')
    {
        neighborhood[deliveryBoyRow, deliveryBoyCol] = '.';
    }
    else if (neighborhood[deliveryBoyRow, deliveryBoyCol] == 'P')
    {
        Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
        neighborhood[deliveryBoyRow, deliveryBoyCol] = 'R';
        pizzaIsCollected = true;
    }
    else if (neighborhood[deliveryBoyRow, deliveryBoyCol] == 'A' && pizzaIsCollected)
    {
        neighborhood[deliveryBoyRow, deliveryBoyCol] = 'P';
        return true;
    }

    return false;
}