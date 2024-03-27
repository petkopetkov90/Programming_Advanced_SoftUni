
int size = int.Parse(Console.ReadLine());

char[,] board = new char[size, size];

int gamblerRow = 0;
int gamblerCol = 0;
int amount = 100;

for (int row = 0; row < size; row++)
{
    string currentRow = Console.ReadLine();

    for (int col = 0; col < size; col++)
    {
        board[row, col] = currentRow[col];

        if (currentRow[col] == 'G')
        {
            board[row, col] = '-';
            gamblerRow = row;
            gamblerCol = col;
        }
    }
}

bool leaveBoundaries = false;
bool hitJackpot = false;

string command;

while ((command = Console.ReadLine()) != "end")
{
    if (command == "up")
    {
        gamblerRow--;
    }
    else if (command == "down")
    {
        gamblerRow++;
    }
    else if (command == "right")
    {
        gamblerCol++;
    }
    else if (command == "left")
    {
        gamblerCol--;
    }

    if (gamblerRow < 0 || gamblerCol < 0 || gamblerRow >= size || gamblerCol >= size)
    {
        leaveBoundaries = true;
        break;
    }

    if (board[gamblerRow, gamblerCol] == 'W')
    {
        amount += 100;
        board[gamblerRow, gamblerCol] = '-';
    }
    else if (board[gamblerRow, gamblerCol] == 'P')
    {
        amount -= 200;
        board[gamblerRow, gamblerCol] = '-';
    }
    else if (board[gamblerRow, gamblerCol] == 'J')
    {
        amount += 100000;
        hitJackpot = true;
        break;
    }

    if (amount <= 0)
    {
        break;
    }
}

board[gamblerRow, gamblerCol] = 'G';

if (leaveBoundaries || amount <= 0)
{
    Console.WriteLine("Game over! You lost everything!");
}
else
{
    if (hitJackpot)
    {
        Console.WriteLine("You win the Jackpot!");
    }

    Console.WriteLine($"End of the game. Total amount: {amount}$");

    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            Console.Write(board[row, col]);
        }

        Console.WriteLine();
    }
}