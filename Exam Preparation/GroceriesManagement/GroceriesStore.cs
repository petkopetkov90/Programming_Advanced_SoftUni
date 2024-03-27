using System.Diagnostics;
using System.Text;

namespace GroceriesManagement
{
    public class GroceriesStore
    {
        public GroceriesStore(int capacity)
        {
            Capacity = capacity;
            Turnover = 0;
            Stall = new List<Product>();
        }

        public int Capacity { get; set; }
        public double Turnover { get; set; }
        public List<Product> Stall { get; set; }

        public void AddProduct(Product product)
        {
            if (Stall.Count < Capacity && !Stall.Any(p => p.Name == product.Name))
            {
                Stall.Add(product);
            }
        }

        public bool RemoveProduct(string name)
        {
            if (Stall.Any(p => p.Name == name))
            {
                Stall.Remove(Stall.First(p => p.Name == name));
                return true;
            }

            return false;
        }

        public string SellProduct(string name, double quantity)
        {
            Product product = Stall.FirstOrDefault(p => p.Name == name);

            if (product == null)
            {
                return $"Product not found";
            }

            double totalPrice = Math.Round((product.Price * quantity), 2);
            Turnover += totalPrice;

            return $"{product.Name} - {totalPrice:F2}$";
        }

        public string GetMostExpensive()
        {
            return Stall.MaxBy(p => p.Price).ToString();
        }

        public string CashReport()
        {
            return $"Total Turnover: {Turnover:F2}$";
        }

        public string PriceList()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Groceries Price List:");

            foreach (Product product in Stall)
            {
                stringBuilder.AppendLine(product.ToString());
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
