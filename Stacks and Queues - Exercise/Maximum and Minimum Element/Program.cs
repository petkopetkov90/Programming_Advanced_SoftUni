namespace Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            int orders = int.Parse(Console.ReadLine());
            for (int i = 0; i < orders; i++)
            {
                string orderDetails = Console.ReadLine();
                if (orderDetails.Contains("1"))
                {
                    string element = orderDetails.Split()[1];
                    stack.Push(element);
                }
                else if (orderDetails.Contains("2"))
                {
                    stack.Pop();
                }
                else if (orderDetails.Contains("3") && stack.Count > 0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (orderDetails.Contains("4") && stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
