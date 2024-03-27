namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < lines.Length; i++)
            {
                int letters = lines[i].Count(ch => char.IsLetter(ch));
                int punctuations = lines[i].Count(ch => char.IsPunctuation(ch));

                stringBuilder.AppendLine($"Line {i+1}: {lines[i]} ({letters})({punctuations})");
            }

            File.AppendAllText(outputFilePath, stringBuilder.ToString());
        }
    }
}
