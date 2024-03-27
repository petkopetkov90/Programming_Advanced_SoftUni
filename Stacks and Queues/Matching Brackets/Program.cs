namespace Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> stackIndexes = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    stackIndexes.Push(i);
                }

                if (expression[i] == ')')
                {
                    int startIndex = stackIndexes.Pop();
                    int endIndex = i + 1;
                    Console.WriteLine(expression.Substring(startIndex, endIndex - startIndex));
                }
            }
        }
    }
}
