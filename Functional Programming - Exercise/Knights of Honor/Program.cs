namespace Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Action<string, List<string>> print = (prefix, list) => list.ForEach(name => Console.WriteLine($"{prefix} {name}"));

            print("sir", names);
        }
    }
}
