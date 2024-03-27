
int size = int.Parse(Console.ReadLine());

char[,] airspace = new char[size, size];

int jetfighterRow = 0;
int jetfighterCol = 0;
int jetfighterArmor = 300;
int enemyAircrafts = 0;

for (int row = 0; row < size; row++)
{
    string currentRow = Console.ReadLine();

    for (int col = 0; col < size; col++)
    {
        airspace[row, col] = currentRow[col];

        if (airspace[row, col] == 'J')
        {
            jetfighterRow = row;
            jetfighterCol = col;
            airspace[row, col] = '-';
        }
        if (airspace[row, col] == 'E')
        {
            enemyAircrafts++;
        }
    }
}

bool jetCrashes = false;

while (jetfighterArmor > 0 && enemyAircrafts > 0)
{
    string command = Console.ReadLine();

    JetfighterMove(command);

    if (airspace[jetfighterRow, jetfighterCol] == 'E')
    {
        airspace[jetfighterRow, jetfighterCol] = '-';

        enemyAircrafts--;

        if (enemyAircrafts > 0)
        {
            jetfighterArmor -= 100;

            if (jetfighterArmor == 0)
            {
                jetCrashes = true;
            }
        }
    }
    else if (airspace[jetfighterRow, jetfighterCol] == 'R')
    {
        airspace[jetfighterRow, jetfighterCol] = '-';
        jetfighterArmor = 300;
    }
}

airspace[jetfighterRow, jetfighterCol] = 'J';

if (jetCrashes)
{
    Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{jetfighterRow}, {jetfighterCol}]!");
}
else
{
    Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
}


for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        Console.Write(airspace[row, col]);
    }

    Console.WriteLine();
}

void JetfighterMove(string command)
{
    if (command == "up")
    {
        jetfighterRow--;
    }
    else if (command == "down")
    {
        jetfighterRow++;
    }
    else if (command == "right")
    {
        jetfighterCol++;
    }
    else if (command == "left")
    {
        jetfighterCol--;
    }
}