namespace The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedSet<string>> vloggersFollowers = new Dictionary<string, SortedSet<string>>();
            Dictionary<string, HashSet<string>> vloggersFollowing = new Dictionary<string, HashSet<string>>();

            string command;
            while ((command = Console.ReadLine()) != "Statistics")
            {
                string[] commandInfo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (commandInfo.Length > 3)
                {
                    string vlogger = commandInfo[0];

                    if (!vloggersFollowers.ContainsKey(vlogger))
                    {
                        vloggersFollowers.Add(vlogger, new SortedSet<string>());
                        vloggersFollowing.Add(vlogger, new HashSet<string>());
                    }
                }

                if (commandInfo.Length == 3)
                {
                    string follower = commandInfo[0];
                    string vlogger = commandInfo[2];

                    if (vloggersFollowers.ContainsKey(follower) && vloggersFollowers.ContainsKey(vlogger) && follower != vlogger)
                    {
                        vloggersFollowers[vlogger].Add(follower);
                        vloggersFollowing[follower].Add(vlogger);
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vloggersFollowers.Count} vloggers in its logs.");

            var orderedVloggers = vloggersFollowers.OrderByDescending(v => v.Value.Count()).ThenBy(v => vloggersFollowing[v.Key].Count).ToDictionary(k => k.Key, v => v.Value);

            int rank = 1;

            foreach (var vlogger in orderedVloggers)
            {
                Console.WriteLine($"{rank}. {vlogger.Key} : {vlogger.Value.Count} followers, {vloggersFollowing[vlogger.Key].Count} following");

                if (rank == 1)
                {
                    foreach (var follower in vlogger.Value)
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                rank++;
            }
        }
    }
}
