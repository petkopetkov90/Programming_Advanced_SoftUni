namespace Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());
            SortedSet<string> chemicalElements = new SortedSet<string>();

            for (int i = 0; i < inputLines; i++)
            {
                string[] inputElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < inputElements.Length; j++)
                {
                    chemicalElements.Add(inputElements[j]);
                }
            }

            Console.WriteLine(string.Join(" ", chemicalElements));
        }
    }
}
