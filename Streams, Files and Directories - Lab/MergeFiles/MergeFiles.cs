namespace MergeFiles
{
    using System;
    using System.IO;
    using System.Text;

    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            string[] linesFromFirstInput = File.ReadAllLines(firstInputFilePath);
            string[] linesFromSecondInput = File.ReadAllLines(secondInputFilePath);
            int counter = Math.Max(linesFromFirstInput.Length, linesFromSecondInput.Length);
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < counter; i++)
            {
                if (i < linesFromFirstInput.Length)
                {
                    stringBuilder.AppendLine(linesFromFirstInput[i]);
                }
                if (i < linesFromSecondInput.Length)
                {
                    stringBuilder.AppendLine(linesFromSecondInput[i]);
                }
            }

            File.WriteAllText(outputFilePath, stringBuilder.ToString());
        }
    }
}
