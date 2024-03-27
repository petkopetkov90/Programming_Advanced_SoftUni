namespace Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cupsInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> cups = new Queue<int>(cupsInput);

            int[] bottlesInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> bottles = new Stack<int>(bottlesInput);

            int waterWasted = 0;

            while (cups.Count > 0 && bottles.Count > 0)
            {
                int currentCup = cups.Peek();

                while (bottles.Count > 0)
                {
                    int currentBottle = bottles.Pop();
                    currentCup -= currentBottle;
                    if (currentCup <= 0)
                    {
                        waterWasted += Math.Abs(currentCup);
                        cups.Dequeue();
                        break;
                    }
                }
            }

            if (cups.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }

            Console.WriteLine($"Wasted litters of water: {waterWasted}");
        }
    }
}
