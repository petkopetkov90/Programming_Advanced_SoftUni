namespace Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shopsProductsPrices = new();

            string input;
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] inputDetails = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shopName = inputDetails[0];
                string product = inputDetails[1];
                double price = double.Parse(inputDetails[2]);

                if (!shopsProductsPrices.ContainsKey(shopName))
                {
                    shopsProductsPrices.Add(shopName, new Dictionary<string, double>());
                }

                if (!shopsProductsPrices[shopName].ContainsKey(product))
                {
                    shopsProductsPrices[shopName].Add(product, price);
                }
            }
            foreach (var shopProducs in shopsProductsPrices)
            {
                Console.WriteLine($"{shopProducs.Key}->");

                foreach (var product in shopProducs.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
