namespace Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbersCount = new Dictionary<int, int>();
            int inputCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!numbersCount.ContainsKey(number))
                {
                    numbersCount.Add(number, 0);
                }

                numbersCount[number]++;
            }

            Console.WriteLine(numbersCount.Single(numberCount => numberCount.Value % 2 == 0).Key);
        }
    }
}