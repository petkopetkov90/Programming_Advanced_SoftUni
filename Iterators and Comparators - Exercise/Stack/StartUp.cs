
using Stack;

CustomStack<int> customStack = new CustomStack<int>();

string command;
while ((command = Console.ReadLine()) != "END")
{
    if (command.Contains("Push"))
    {
        int[] elements = command.Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries)
            .Skip(1)
            .Select(int.Parse)
            .ToArray();

        customStack.Push(elements);
    }
    else if (command.Contains("Pop"))
    {
        try
        {
            customStack.Pop();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}

foreach (var element in customStack)
{
    Console.WriteLine(element);
}

foreach (var element in customStack)
{
    Console.WriteLine(element);
}