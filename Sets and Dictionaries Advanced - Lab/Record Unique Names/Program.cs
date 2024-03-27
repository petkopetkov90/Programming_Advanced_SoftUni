namespace Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < inputCount; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            Console.WriteLine(string.Join("\n", names));
        }
    }
}
