
Queue<int> monstersArmor = new Queue<int>(Console.ReadLine()
    .Split(",", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));


Stack<int> soldierStrikes = new Stack<int>(Console.ReadLine()
    .Split(",", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int killedMonsters = 0;

while (monstersArmor.Count > 0 && soldierStrikes.Count > 0)
{
    int armor = monstersArmor.Dequeue();
    int strike = soldierStrikes.Pop();

    if (strike >= armor)
    {
        killedMonsters++;

        strike -= armor;

        if (strike > 0)
        {
            if (soldierStrikes.Count > 0)
            {
                strike += soldierStrikes.Pop();
            }

            soldierStrikes.Push(strike);
        }
    }
    else
    {
        armor -= strike;
        monstersArmor.Enqueue(armor);
    }
}

if (!monstersArmor.Any())
{
    Console.WriteLine("All monsters have been killed!");
}
if (!soldierStrikes.Any())
{
    Console.WriteLine("The soldier has been defeated.");
}

Console.WriteLine($"Total monsters killed: {killedMonsters}");