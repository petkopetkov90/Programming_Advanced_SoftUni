namespace Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;

            Func<List<int>, string, List<int>> changeListByCommand = (list, command) =>
            {
                List<int> newList = new List<int>();
                foreach (int number in list)
                {
                    switch (command)
                    {
                        case "add":
                            newList.Add(number + 1);
                            break;
                        case "multiply":
                            newList.Add(number * 2);
                            break;
                        case "subtract":
                            newList.Add(number - 1);
                            break;
                        default:
                            newList.Add(number);
                            break;
                    }
                }

                return newList;
            };

            Action<List<int>> print = list => Console.WriteLine(string.Join(" ", list));

            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "print")
                {
                    print(numbers);
                }
                else
                {
                    numbers = changeListByCommand(numbers, command);
                }
            }
        }
    }
}
