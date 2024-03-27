using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingSystem
{
    public class VendingMachine
    {
        public VendingMachine(int buttonCapacity)
        {
            ButtonCapacity = buttonCapacity;
            Drinks = new List<Drink>();
        }

        public int ButtonCapacity { get; set; }
        public List<Drink> Drinks { get; set; }
        public int GetCount { get { return Drinks.Count; } }

        public void AddDrink(Drink drink)
        {
            if (Drinks.Count < ButtonCapacity)
            {
                Drinks.Add(drink);
            }
        }

        public bool RemoveDrink(string name)
        {
            if (!Drinks.Any(d => d.Name == name))
            {
                return false;
            }

            Drinks.Remove(Drinks.First(d => d.Name == name));
            return true;
        }

        public Drink GetLongest() => Drinks.MaxBy(d => d.Volume);
        public Drink GetCheapest() => Drinks.MinBy(d => d.Price);
        public string BuyDrink(string name) => Drinks.First(d => d.Name == name).ToString();
        public string Report()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Drinks available:");

            foreach (Drink drink in Drinks)
            {
                stringBuilder.AppendLine(drink.ToString());
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
