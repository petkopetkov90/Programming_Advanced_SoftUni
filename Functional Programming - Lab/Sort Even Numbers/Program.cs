namespace Sort_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = Console.ReadLine()
            //    .Split(",", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(n => int.Parse(n))
            //    .Where(n => n % 2 == 0)
            //    .OrderBy(n => n)
            //    .ToList();

            List<int> numbers = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Predicate<int> checkForEven = number => number % 2 == 0;

            Func<List<int>, Predicate<int>, List<int>> getEvenNumbers = (numbers, predicate) =>
            {
                List<int> evenNumbers = new List<int>();
                foreach (var number in numbers)
                {
                    if (checkForEven(number))
                    {
                        evenNumbers.Add(number);
                    }
                }

                return evenNumbers;
            };

            Func<List<int>, List<int>> sortedNumbers = numbers =>
            {
                List<int> sortedNumbers = new List<int>();
                List<int> currentList = new List<int>();

                foreach (int number in numbers)
                {
                    currentList.Add(number);
                }

                while (currentList.Count > 0)
                {
                    int minNumber = int.MaxValue;

                    foreach (var number in currentList)
                    {
                        if (number < minNumber)
                        {
                            minNumber = number;
                        }
                    }

                    sortedNumbers.Add(minNumber);
                    currentList.Remove(minNumber);
                }

                return sortedNumbers;

            };

            numbers = getEvenNumbers(numbers, checkForEven);
            numbers = sortedNumbers(numbers);

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
