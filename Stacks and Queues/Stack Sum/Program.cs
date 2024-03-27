namespace Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stackNumbers = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            string commandOrEnd;
            while ((commandOrEnd = Console.ReadLine().ToLower()) != "end")
            {
                string[] command = commandOrEnd.Split();
                if (command[0] == "add")
                {
                    stackNumbers.Push(int.Parse(command[1]));
                    stackNumbers.Push(int.Parse(command[2]));
                }
                else if (command[0] == "remove")
                {
                    int count = int.Parse(command[1]);
                    if (count <= stackNumbers.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stackNumbers.Pop();
                        }
                    }
                }
            }

            int sum = 0;
            foreach (int number in stackNumbers)
            {
                sum += number;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}