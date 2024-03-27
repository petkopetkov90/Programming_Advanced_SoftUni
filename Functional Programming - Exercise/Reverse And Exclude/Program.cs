namespace Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int diviseur = int.Parse(Console.ReadLine());

            Predicate<int> predicate = GeneratePredicate(diviseur);

            Func<List<int>, Predicate<int>, List<int>> removeElemetsByPredicate = (list, predicate) =>
            {
                List<int> newList = new List<int>();

                foreach (int number in list)
                {
                    if (!predicate(number))
                    {
                        newList.Add(number);
                    }
                }

                return newList;
            };

            Func<List<int>, List<int>> reverseList = list =>
            {
                List<int> newList = new List<int>();

                for (int i = list.Count - 1; i  >= 0; i --)
                {
                    newList.Add(list[i]);
                }

                return newList;
            };

            numbers = removeElemetsByPredicate(numbers, predicate);
            numbers = reverseList(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static Predicate<int> GeneratePredicate(int diviseur)
        {
            return n => n % diviseur == 0;
        }
    }
}
