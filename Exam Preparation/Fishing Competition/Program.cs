
int size = int.Parse(Console.ReadLine());

char[,] fishingArea = new char[size, size];

int fisherRow = 0;
int fisherCol = 0;

for (int row = 0; row < size; row++)
{
    string currentRow = Console.ReadLine();

    for (int col = 0; col < size; col++)
    {
        fishingArea[row, col] = currentRow[col];

        if (fishingArea[row, col] == 'S')
        {
            fisherRow = row;
            fisherCol = col;
            fishingArea[row, col] = '-';
        }
    }
}

int fishedTons = 0;
bool sink = false;

string command;
while ((command = Console.ReadLine()) != "collect the nets")
{
    if (command == "up")
    {
        fisherRow--;

        if (fisherRow < 0)
        {
            fisherRow = size - 1;
        }

        if (char.IsDigit(fishingArea[fisherRow, fisherCol]))
        {
            fishedTons += int.Parse(fishingArea[fisherRow, fisherCol].ToString());
            fishingArea[fisherRow, fisherCol] = '-';
        }
        else if (fishingArea[fisherRow, fisherCol] == 'W')
        {
            fishedTons = 0;
            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{fisherRow},{fisherCol}]");
            sink = true;
            break;
        }

    }
    else if (command == "down")
    {
        fisherRow++;

        if (fisherRow >= size)
        {
            fisherRow = 0;
        }

        if (char.IsDigit(fishingArea[fisherRow, fisherCol]))
        {
            fishedTons += int.Parse(fishingArea[fisherRow, fisherCol].ToString());
            fishingArea[fisherRow, fisherCol] = '-';
        }
        else if (fishingArea[fisherRow, fisherCol] == 'W')
        {
            fishedTons = 0;
            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{fisherRow},{fisherCol}]");
            sink = true;
            break;
        }

    }
    else if (command == "right")
    {
        fisherCol++;

        if (fisherCol >= size)
        {
            fisherCol = 0;
        }

        if (char.IsDigit(fishingArea[fisherRow, fisherCol]))
        {
            fishedTons += int.Parse(fishingArea[fisherRow, fisherCol].ToString());
            fishingArea[fisherRow, fisherCol] = '-';
        }
        else if (fishingArea[fisherRow, fisherCol] == 'W')
        {
            fishedTons = 0;
            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{fisherRow},{fisherCol}]");
            sink = true;
            break;
        }
    }
    else if (command == "left")
    {
        fisherCol--;

        if (fisherCol < 0)
        {
            fisherCol = size - 1;
        }

        if (char.IsDigit(fishingArea[fisherRow, fisherCol]))
        {
            fishedTons += int.Parse(fishingArea[fisherRow, fisherCol].ToString());
            fishingArea[fisherRow, fisherCol] = '-';
        }
        else if (fishingArea[fisherRow, fisherCol] == 'W')
        {
            fishedTons = 0;
            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{fisherRow},{fisherCol}]");
            sink = true;
            break;
        }
    }
}

if (!sink)
{
    if (fishedTons >= 20)
    {
        Console.WriteLine("Success! You managed to reach the quota!");
    }
    else
    {
        Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - fishedTons} tons of fish more.");
    }

    if (fishedTons > 0)
    {
        Console.WriteLine($"Amount of fish caught: {fishedTons} tons.");
    }

    fishingArea[fisherRow, fisherCol] = 'S';

    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            Console.Write(fishingArea[row, col]);
        }

        Console.WriteLine();
    }
}
