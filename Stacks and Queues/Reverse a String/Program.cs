namespace Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> text = new Stack<char>();

            foreach (char @char in input)
            {
                text.Push(@char);
            }

            Console.Write(string.Join("", text));

        }
    }
}
