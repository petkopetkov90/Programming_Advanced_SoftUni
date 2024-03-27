namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] expression = Console.ReadLine().Split();
            Stack<string> stackExpression = new Stack<string>(expression.Reverse());

            int sum = int.Parse(stackExpression.Pop());

            while (stackExpression.Count > 0)
            {
                string operation = stackExpression.Pop();
                int nextNumber = int.Parse(stackExpression.Pop());

                if (operation == "+")
                {
                    sum += nextNumber;
                }
                else
                {
                    sum -= nextNumber;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
