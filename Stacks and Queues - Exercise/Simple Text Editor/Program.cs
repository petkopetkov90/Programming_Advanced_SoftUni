using System.Text;

namespace Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            Stack<string> stringStates = new Stack<string>();
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "1":
                        string textToAdd = command[1];
                        stringBuilder.Append(textToAdd);
                        stringStates.Push(stringBuilder.ToString());
                        break;
                    case "2":
                        int count = int.Parse(command[1]);
                        stringBuilder = stringBuilder.Remove(stringBuilder.Length - count, count);
                        stringStates.Push(stringBuilder.ToString());
                        break;
                    case "3":
                        int index = int.Parse(command[1]) - 1;
                        Console.WriteLine(stringBuilder[index]);
                        break;
                    case "4":
                        stringStates.Pop();
                        stringBuilder.Clear();
                        if (stringStates.Count > 0)
                        {
                            stringBuilder.Append(stringStates.Peek());
                        }
                        break;
                }
            }
        }
    }
}
