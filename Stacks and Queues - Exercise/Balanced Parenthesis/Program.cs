namespace Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] paparentheses = Console.ReadLine().ToCharArray();
            Stack<char> openParentheses = new Stack<char>();
            for (int i = 0; i < paparentheses.Length; i++)
            {
                if (paparentheses[i] == '('
                    || paparentheses[i] == '['
                    || paparentheses[i] == '{')
                {
                    openParentheses.Push(paparentheses[i]);
                }

                if(openParentheses.Count == 0)
                {
                    openParentheses.Push(paparentheses[i]);
                    break;
                }

                if ((paparentheses[i] == ')' && openParentheses.Peek() == '(')
                    || (paparentheses[i] == ']' && openParentheses.Peek() == '[')
                    || (paparentheses[i] == '}' && openParentheses.Peek() == '{'))
                {
                    openParentheses.Pop();
                }
            }

            if (openParentheses.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}