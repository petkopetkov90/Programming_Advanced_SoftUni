namespace Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quatityOfFood = int.Parse(Console.ReadLine());
            Queue<int> ordersQueue = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            Console.WriteLine(ordersQueue.Max());

            while (quatityOfFood >= 0)
            {
                if (quatityOfFood - ordersQueue.Peek() < 0)
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", ordersQueue)}");
                    break;
                }

                quatityOfFood -= ordersQueue.Dequeue();
                if (ordersQueue.Count == 0)
                {
                    Console.WriteLine("Orders complete");
                    break;
                }
            }
        }
    }
}
