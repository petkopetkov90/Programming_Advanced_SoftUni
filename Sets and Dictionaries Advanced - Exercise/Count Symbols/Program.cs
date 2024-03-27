namespace Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> symbolsCount = new SortedDictionary<char, int>();
            char[] symbols = Console.ReadLine().ToCharArray();

            foreach (char ch in symbols)
            {
                if (!symbolsCount.ContainsKey(ch))
                {
                    symbolsCount.Add(ch, 0);
                }

                symbolsCount[ch]++;
            }

            foreach (var symbolCount in symbolsCount)
            {
                Console.WriteLine($"{symbolCount.Key}: {symbolCount.Value} time/s");
            }
        }
    }
}
