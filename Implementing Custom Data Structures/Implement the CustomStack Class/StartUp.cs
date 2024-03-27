using System.Reflection.Metadata;

namespace Implement_the_CustomStack_Class
{
    internal class StartUp
    {
        static void Main()
        {
            CustomStack stack = new CustomStack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Console.WriteLine(stack.Count);

            Console.WriteLine(stack.Peek());

            stack.ForEach(x => Console.WriteLine(x));

            Console.WriteLine(stack.Contains(1));
            Console.WriteLine(stack.Contains(5));

            Console.WriteLine(stack.Sum());
            Console.WriteLine(stack.Average());

            stack.Clear();

            Console.WriteLine(stack.Count);
        }
    }
}
