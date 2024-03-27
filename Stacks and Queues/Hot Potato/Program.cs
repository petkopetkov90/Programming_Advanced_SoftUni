namespace Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int tosses = int.Parse(Console.ReadLine());

            Queue<string> kids = new Queue<string>(input);
            int currentTosses = 0;

            while (kids.Count > 1)
            {
                string currentKid = kids.Dequeue();
                currentTosses++;

                if (currentTosses == tosses)
                {
                    currentTosses = 0;
                    Console.WriteLine($"Removed {currentKid}");
                }
                else
                {
                    kids.Enqueue(currentKid);
                }
            }

            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}
