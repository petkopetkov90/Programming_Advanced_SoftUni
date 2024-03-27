namespace Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int elementsToEnqueue = input[0];
            int elementsToDequeue = input[1];
            int elementToFind = input[2];

            input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> elements = new Queue<int>(input);

            for (int i = 0; i < elementsToDequeue; i++)
            {
                int element = elements.Dequeue();
                if (elements.Count == 0)
                {
                    break;
                }
            }
            if (elements.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (elements.Contains(elementToFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(elements.Min());
            }
        }
    }
}
