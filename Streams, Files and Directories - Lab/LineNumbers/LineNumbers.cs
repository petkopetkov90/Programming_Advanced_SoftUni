namespace LineNumbers
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            List<string> lines = new List<string>();

            using (StreamReader streamReader = new StreamReader(inputFilePath))
            {
                while (!streamReader.EndOfStream)
                {
                    lines.Add(streamReader.ReadLine());
                }
            }

            using (StreamWriter streamWriter = new StreamWriter(outputFilePath))
            {
                for (int i = 0; i < lines.Count; i++)
                {
                    streamWriter.WriteLine($"{i + 1}. {lines[i]}");
                }
            }

            //string[] lines = File.ReadAllLines(inputFilePath);
            //StringBuilder stringBuilder = new StringBuilder();

            //for (int i = 0; i < lines.Length; i++)
            //{
            //    stringBuilder.AppendLine($"{i + 1}. {lines[i]}");
            //}

            //File.WriteAllText(outputFilePath, stringBuilder.ToString().TrimEnd());
        }
    }
}
