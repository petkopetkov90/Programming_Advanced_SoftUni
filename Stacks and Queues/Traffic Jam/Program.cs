namespace Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carsPerGreenLight = int.Parse(Console.ReadLine());
            Queue<string> carsQueue = new Queue<string>();
            int carsPassed = 0;
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input != "green")
                {
                    carsQueue.Enqueue(input);
                    continue;
                }

                for (int i = 0; i < carsPerGreenLight; i++)
                {
                    if (carsQueue.Count > 0)
                    {
                        Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                        carsPassed++;
                    }
                }
            }

            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }
    }
}
