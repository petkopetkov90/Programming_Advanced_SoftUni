namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid" && names.Count > 0)
                {
                    foreach (string name in names)
                    {
                        Console.WriteLine(name);
                    }

                    names.Clear();
                }
                else
                {
                    names.Enqueue(input);
                }
            }

            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
