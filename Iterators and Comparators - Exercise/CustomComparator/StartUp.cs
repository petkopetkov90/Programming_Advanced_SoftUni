using System.Linq;

int[] array = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Comparator comparator = new Comparator();

Array.Sort(array, comparator);

Console.WriteLine(string.Join(" ", array));

public class Comparator : IComparer<int>
{
    public int Compare(int x, int y)
    {
        if (x % 2 == 0 && y % 2 != 0)
        {
            return -1;
        }
        else if (y % 2 == 0 && x % 2 != 0)
        {
            return 1;
        }

        return x.CompareTo(y);
    }
}