namespace Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputCounts = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstSetCount = inputCounts[0];
            int secondSetCount = inputCounts[1];

            HashSet<int> firstNumbers = new HashSet<int>();
            HashSet<int> secondNumbers = new HashSet<int>();
            AddInHashSet(firstSetCount, firstNumbers);
            AddInHashSet(secondSetCount, secondNumbers);

            firstNumbers.IntersectWith(secondNumbers);
            Console.WriteLine(string.Join(" ", firstNumbers));
        }

        private static void AddInHashSet(int inputCount, HashSet<int> numbers)
        {
            for (int i = 0; i < inputCount; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
        }
    }
}
