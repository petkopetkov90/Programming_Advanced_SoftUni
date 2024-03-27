
Stack<int> worms = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Queue<int> holes = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int matchesCount = 0;
bool everyWormSuits = true;

while (worms.Count > 0 && holes.Count > 0)
{
    int worm = worms.Pop();
    int hole = holes.Dequeue();

    if (worm != hole)
    {
        worm -= 3;
        everyWormSuits = false;

        if (worm > 0)
        {
            worms.Push(worm);
        }
    }
    else
    {
        matchesCount++;
    }
}

if (matchesCount > 0)
{
    Console.WriteLine($"Matches: {matchesCount}");
}
else
{
    Console.WriteLine("There are no matches.");
}

if (!worms.Any())
{
    if (everyWormSuits)
    {
        Console.WriteLine("Every worm found a suitable hole!");
    }
    else
    {
        Console.WriteLine("Worms left: none");
    }
}
else
{
    Console.WriteLine($"Worms left: {string.Join(", ", worms)}");
}
if (holes.Any())
{
    Console.WriteLine($"Holes left: {string.Join(", ", holes)}");
}
else
{
    Console.WriteLine("Holes left: none");
}