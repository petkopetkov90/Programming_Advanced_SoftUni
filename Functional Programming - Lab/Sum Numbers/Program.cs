namespace Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            //Console.WriteLine(numbers.Count);
            //Console.WriteLine(numbers.Sum());

            Func<List<int>, int> getCountOfNumber = numbers =>
            {
                int count = 0;

                foreach (int number in numbers)
                {
                    count++;
                }

                return count;
            };

            Func<List<int>, int> getSumOfNumbers = numbers =>
            {
                int sum = 0;

                foreach(int number in numbers)
                {
                    sum += number;
                }

                return sum;
            };

            Console.WriteLine(getCountOfNumber(numbers));
            Console.WriteLine(getSumOfNumbers(numbers));
        }
    }
}
