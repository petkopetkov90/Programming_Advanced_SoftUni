namespace SoftUni_Exam_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> usersLanguagesPoints = new SortedDictionary<string, Dictionary<string, int>>();
            SortedDictionary<string, int> languagesSubmissions = new SortedDictionary<string, int>();

            string input;
            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] commandDetails = input.Split("-", StringSplitOptions.RemoveEmptyEntries);

                if (commandDetails.Length > 2)
                {
                    string username = commandDetails[0];
                    string language = commandDetails[1];
                    int points = int.Parse(commandDetails[2]);

                    if (!languagesSubmissions.ContainsKey(language))
                    {
                        languagesSubmissions.Add(language, 0);
                    }

                    languagesSubmissions[language]++;

                    if (!usersLanguagesPoints.ContainsKey(username))
                    {
                        usersLanguagesPoints.Add(username, new Dictionary<string, int>());
                    }

                    if (!usersLanguagesPoints[username].ContainsKey(language))
                    {
                        usersLanguagesPoints[username].Add(language, points);
                    }
                    else
                    {
                        if (usersLanguagesPoints[username][language] < points)
                        {
                            usersLanguagesPoints[username][language] = points;
                        }
                    }
                }
                else
                {
                    string username = commandDetails[0];
                    usersLanguagesPoints.Remove(username);
                }
            }

            Console.WriteLine("Results:");

            foreach (var user in usersLanguagesPoints.OrderByDescending(u => u.Value.Values.Max()))
            {
                Console.WriteLine($"{user.Key} | {user.Value.Values.Max()}");
            }

            Console.WriteLine("Submissions:");

            foreach (var submission in languagesSubmissions.OrderByDescending(s => s.Value))
            {
                Console.WriteLine($"{submission.Key} - {submission.Value}");
            }
        }
    }
}
