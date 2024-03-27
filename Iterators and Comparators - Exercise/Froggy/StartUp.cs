
using Froggy;

int[] stones = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Lake lake = new Lake(stones);

Console.WriteLine(string.Join(", ", lake));