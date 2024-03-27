namespace Predicate_Party_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<string> peoples = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "Party!")
            {
                string[] commandInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = commandInfo[0];
                string condition = commandInfo[1];
                string value = commandInfo[2];

                Predicate<string> predicate = GetPredicate(condition, value);

                if (command == "Remove")
                {
                    peoples.RemoveAll(p => predicate(p));
                }
                else if (command == "Double")
                {
                    List<string> peoplesToDouble = peoples.Where(p => predicate(p)).ToList();

                    foreach (string person in peoplesToDouble)
                    {
                        int index = peoples.IndexOf(person);
                        peoples.Insert(index, person);
                    }
                }
            }

            if (peoples.Any())
            {
                Console.WriteLine($"{string.Join(", ", peoples)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }

        }
        static Predicate<string> GetPredicate(string condition, string value)
        {
            switch (condition)
            {
                case "StartsWith":
                    return p => p.StartsWith(value);
                case "EndsWith":
                    return p => p.EndsWith(value);
                case "Length":
                    return p => p.Length == int.Parse(value);
                default:
                    return default;
            }
        }
    }
}
