namespace ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedSet<string>> sidesUsers = new SortedDictionary<string, SortedSet<string>>();

            string input;
            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                if (input.Contains('|'))
                {
                    string side = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries)[0];
                    string user = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries)[1];

                    if (!sidesUsers.ContainsKey(side))
                    {
                        sidesUsers.Add(side, new SortedSet<string>());
                    }

                    if (!sidesUsers.Any(s => s.Value.Contains(user)))
                    {
                        sidesUsers[side].Add(user);
                    }
                }
                else
                {
                    string side = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries)[1];
                    string user = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries)[0];

                    if (sidesUsers.Values.Any(x => x.Contains(user)))
                    {
                        sidesUsers.First(x => x.Value.Contains(user)).Value.Remove(user);
                    }

                    if (!sidesUsers.ContainsKey(side))
                    {
                        sidesUsers.Add(side, new SortedSet<string>());
                    }

                    sidesUsers[side].Add(user);

                    Console.WriteLine($"{user} joins the {side} side!");
                }
            }

            foreach (var side in sidesUsers.OrderByDescending(s => s.Value.Count()))
            {
                if (side.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count} ");

                    foreach (var user in side.Value)
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }
    }
}
