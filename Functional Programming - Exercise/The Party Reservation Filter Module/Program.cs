namespace The_Party_Reservation_Filter_Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> invitations = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string,Predicate<string>> filters = new Dictionary<string, Predicate<string>>();

            string input;
            
            while ((input = Console.ReadLine()) != "Print")
            {
                string[] commandInfo = input.Split(";", StringSplitOptions.RemoveEmptyEntries);
                string command = commandInfo[0];
                string filterType = commandInfo[1];
                string parameter = commandInfo[2];

                Predicate<string> filter = GenerateFilter(filterType, parameter);

                if (command == "Add filter")
                {
                    filters.Add(filterType + parameter,filter);
                }
                else if (command == "Remove filter")
                {
                    filters.Remove(filterType + parameter);
                }
            }

            foreach (var filter in filters)
            {
                invitations.RemoveAll(name => filter.Value(name));
            }

            Console.WriteLine(string.Join(" ", invitations));
        }

        private static Predicate<string> GenerateFilter(string filterType, string parameter)
        {
            switch(filterType)
            {
                case "Starts with":
                    return name => name.StartsWith(parameter);
                case "Ends with":
                    return name => name.EndsWith(parameter);
                case "Length":
                    return name => name.Length == int.Parse(parameter);
                case "Contains":
                    return name => name.Contains(parameter);
                default:
                    return default;
            }
        }
    }
}
