namespace Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputsCount = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continentsCountriesAndCities = new();

            for (int i = 0; i < inputsCount; i++)
            {
                string[] inputDetails = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string continent = inputDetails[0];
                string country = inputDetails[1];
                string city = inputDetails[2];

                if (!continentsCountriesAndCities.ContainsKey(continent))
                {
                    continentsCountriesAndCities.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!continentsCountriesAndCities[continent].ContainsKey(country))
                {
                    continentsCountriesAndCities[continent].Add(country, new List<string>());
                }

                continentsCountriesAndCities[continent][country].Add(city);
            }

            foreach (var continent in continentsCountriesAndCities)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var countryCities in continent.Value)
                {
                    Console.WriteLine($"{countryCities.Key} -> {string.Join(", ", countryCities.Value)}");
                }
            }
        }
    }
}
