namespace List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startRange = 1;
            int endRange = int.Parse(Console.ReadLine());
            HashSet<int> dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToHashSet();

            List<int> numbers = Enumerable.Range(startRange, (endRange - startRange + 1)).ToList();

            Func<List<int>, HashSet<int>, List<int>> getNumbersByDividers = (numbers, dividers) =>
            {
                List<int> newList = new List<int>();

                foreach (int number in numbers)
                {
                    bool isDivisible = true;

                    foreach (int divider in dividers)
                    {
                        Predicate<int> predicate = n => n % divider == 0;

                        if (!predicate(number))
                        {
                            isDivisible = false;
                            break;
                        }
                    }

                    if (isDivisible)
                    {
                        newList.Add(number);
                    }
                }

                return newList;
            };

            numbers = getNumbersByDividers(numbers, dividers);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
