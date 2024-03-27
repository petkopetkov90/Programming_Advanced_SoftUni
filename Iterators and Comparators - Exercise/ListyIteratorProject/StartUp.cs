using ListyIteratorProject;

string[] createDetails = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Skip(1)
    .ToArray();

ListyIterator<string> ListyIterator = new ListyIterator<string>(createDetails);

string command;
while ((command = Console.ReadLine()) != "END")
{
    if (command == "Move")
    {
        Console.WriteLine(ListyIterator.Move());
    }
    else if (command == "HasNext")
    {
        Console.WriteLine(ListyIterator.HasNext());
    }
    else if (command == "Print")
    {
        try
        {
            ListyIterator.Print();
        }
        catch (Exception exception) 
        {
            Console.WriteLine(exception.Message);
        }
    }
}