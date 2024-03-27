namespace Basic_Stacks_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int elemetsToPush = input[0];
            int elementsToPop = input[1];
            int elementToFind = input[2];
            input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stackOfElements = new Stack<int>(input);

            for (int i = 0; i < elementsToPop; i++)
            {
                stackOfElements.Pop();
            }

            if (stackOfElements.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stackOfElements.Contains(elementToFind))
            {
                Console.WriteLine($"true");
            }
            else
            {
                Console.WriteLine(stackOfElements.Min());
            }
        }
    }
}
