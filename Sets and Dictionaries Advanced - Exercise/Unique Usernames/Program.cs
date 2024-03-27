namespace Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            HashSet<string> usernames = new HashSet<string>();
            List<string> usernamesOrderByInsertion = new List<string>();

            for (int i = 0; i < inputCount; i++)
            {
                string username = Console.ReadLine();

                if (usernames.Add(username))
                {
                    usernamesOrderByInsertion.Add(username);
                }
            }

            foreach (string username in usernamesOrderByInsertion)
            {
                Console.WriteLine(username);
            }
        }
    }
}
