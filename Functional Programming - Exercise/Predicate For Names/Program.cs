namespace Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Predicate<string> checkLenght = name => name.Length <= lenght;

            foreach (string name in names)
            {
                if (checkLenght(name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
