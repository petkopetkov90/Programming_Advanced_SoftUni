namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            using StreamReader reader = new StreamReader(inputFilePath);
            StringBuilder stringBuilder = new StringBuilder();
            int counter = 0;

            while(!reader.EndOfStream)
            {
                string line = reader.ReadLine().Replace('-', '@').Replace(',', '@').Replace('.', '@').Replace('!', '@').Replace('?', '@');

                if (counter++ % 2 == 0)
                {
                    string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    words = words.Reverse().ToArray();
                    stringBuilder.AppendLine(string.Join(" ", words));
                }             
            }

            return stringBuilder.ToString().Trim();
        }
    }
}
