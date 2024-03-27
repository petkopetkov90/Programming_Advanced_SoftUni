namespace Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> printArray = array =>
            {
                foreach (string i in array)
                {
                    Console.WriteLine(i);
                }
            };

            printArray(strings);
        }
    }
}
