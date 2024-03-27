namespace TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<string, int, bool> checkSumOfCharsEqualOrLarger = (givenName, givenNumber) =>
            {
                int sum = 0;
                foreach (char ch in givenName)
                {
                    sum += ch;
                }

                return sum >= givenNumber;
            };

            Func<List<string>, int, Func<string, int, bool>, string> findFirstName = (givenList, givenNumber, givenFunction) =>
            {
                foreach (string name in givenList)
                {
                    if (givenFunction(name, givenNumber))
                    {
                        return name;
                    }
                }

                return default;
            };

            string name = findFirstName(names, number, checkSumOfCharsEqualOrLarger);

            Console.WriteLine(name);
        }
    }
}
