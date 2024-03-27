namespace Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int start = range[0];
            int end = range[1] - range[0] + 1;

            string evenOrOdd = Console.ReadLine();


            Predicate<int> getEvenOrOdd = EvenOrOdd(evenOrOdd);

            List<int> numbers = Enumerable.Range(start, end).Where(n => getEvenOrOdd(n)).ToList();

            Console.WriteLine(string.Join(" ", numbers));

        }

        private static Predicate<int> EvenOrOdd(string evenOrOdd)
        {
            switch (evenOrOdd)
            {
                case "even":
                    return number => number % 2 == 0;
                case "odd":
                    return number => number % 2 != 0;
                default:
                    return default;
            }
        }
    }
}
