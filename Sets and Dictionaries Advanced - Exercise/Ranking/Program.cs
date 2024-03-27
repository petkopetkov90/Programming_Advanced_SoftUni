namespace Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestsPasswords = new Dictionary<string, string>();
            SortedDictionary<string, Dictionary<string, int>> internsContestsPoints = new SortedDictionary<string, Dictionary<string, int>>();

            string input;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] contestInfor = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string contest = contestInfor[0];
                string password = contestInfor[1];
                contestsPasswords.Add(contest, password);
            }

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] userContestPoints = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = userContestPoints[0];
                string password = userContestPoints[1];
                string username = userContestPoints[2];
                int points = int.Parse(userContestPoints[3]);

                if (contestsPasswords.ContainsKey(contest) && contestsPasswords[contest] == password)
                {
                    if (!internsContestsPoints.ContainsKey(username))
                    {
                        internsContestsPoints.Add(username, new Dictionary<string, int>());
                    }

                    if (!internsContestsPoints[username].ContainsKey(contest))
                    {
                        internsContestsPoints[username].Add(contest, points);
                    }
                    else
                    {
                        if (internsContestsPoints[username][contest] < points)
                        {
                            internsContestsPoints[username][contest] = points;
                        }
                    }
                }
            }

            var bestIntern = internsContestsPoints.Keys.OrderByDescending(u => internsContestsPoints[u].Values.Sum()).First();
            int totalPoinst = internsContestsPoints[bestIntern].Values.Sum();
            Console.WriteLine($"Best candidate is {bestIntern} with total {totalPoinst} points.");
            Console.WriteLine("Ranking:");

            foreach (var internContestPoints in internsContestsPoints)
            {
                Console.WriteLine($"{internContestPoints.Key}");

                foreach (var contestPoints in internContestPoints.Value.OrderByDescending(cp => cp.Value))
                {
                    Console.WriteLine($"#  {contestPoints.Key} -> {contestPoints.Value}");
                }
            }
        }
    }
}
