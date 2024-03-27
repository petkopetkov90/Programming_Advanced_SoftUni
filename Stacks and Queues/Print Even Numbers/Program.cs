namespace Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfIntegers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> integers = new Queue<int>(arrayOfIntegers.Where(x => x % 2 == 0));

            Console.WriteLine(string.Join(", ", integers));
        }
    }
}
