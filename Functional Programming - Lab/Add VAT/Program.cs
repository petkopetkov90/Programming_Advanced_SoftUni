namespace Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<decimal> prices = Console.ReadLine()
            //    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(decimal.Parse)
            //    .Select(p => p = p * 1.20m)
            //    .Select(p => Math.Round(p, 2))
            //    .ToList();

            //Console.WriteLine(string.Join(Environment.NewLine, prices));

            Func<string, decimal> decimalParser = price => decimal.Parse(price);
            Func<decimal, decimal> addVAT = price => price = price * 1.20m;
            Func<decimal, decimal> roundedPrice = price => Math.Round(price, 2);

            List<decimal> priceList = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(decimalParser)
                .Select(addVAT)
                .Select(roundedPrice)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, priceList));
        }
    }
}
