namespace Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothesStack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int rackCapacity = int.Parse(Console.ReadLine());
            int usedRacks = 1;
            int currentCapacity = rackCapacity;

            while (clothesStack.Count > 0)
            {
                if (currentCapacity >= clothesStack.Peek())
                {
                    currentCapacity -= clothesStack.Pop();
                }
                else
                {
                    usedRacks++;
                    currentCapacity = rackCapacity - clothesStack.Pop();
                }
            }

            Console.WriteLine(usedRacks);
        }
    }
}
