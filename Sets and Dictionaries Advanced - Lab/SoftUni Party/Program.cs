namespace SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> reservations = new HashSet<string>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                if (input == "PARTY")
                {
                    break;
                }
                reservations.Add(input);
            }

            if (input == "PARTY")
            {
                while ((input = Console.ReadLine()) != "END")
                {
                    reservations.Remove(input);
                }
            }

            Console.WriteLine(reservations.Count);
            if (reservations.Any(r => char.IsDigit(r[0])))
            {
                Console.WriteLine(string.Join("\n", reservations.Where(r => char.IsDigit(r[0]))));
            }
            if (reservations.Any(r => char.IsLetter(r[0])))
            {
                Console.WriteLine(string.Join("\n", reservations.Where(r => char.IsLetter(r[0]))));
            }
        }
    }
}
