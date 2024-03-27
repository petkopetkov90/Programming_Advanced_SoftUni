namespace Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songsQueue = new Queue<string>(Console.ReadLine().Split(", "));
            while (songsQueue.Count > 0)
            {
                string command = Console.ReadLine();
                if(command == "Play")
                {
                    songsQueue.Dequeue();
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }
                else
                {
                    string songName = string.Join(" ",command.Split().Skip(1));
                    if (songsQueue.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained!");
                        continue;
                    }

                    songsQueue.Enqueue(songName);
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
