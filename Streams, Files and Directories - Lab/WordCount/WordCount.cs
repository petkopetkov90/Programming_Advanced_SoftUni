namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            string[] wordsToFind = File.ReadAllText(wordsFilePath).Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(w => w.ToLower())
                .ToArray();

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (string word in wordsToFind)
            {
                wordsCount.Add(word, 0);
            }

            string[] lines = File.ReadAllLines(textFilePath);

            Regex regex = new Regex(@"[^\w\s]|[^\w\s]\b");
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = regex.Replace(lines[i], " ");
            }


            foreach (var line in lines)
            {
                string[] currentWords = line.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(w => w.ToLower())
                    .ToArray();

                foreach (string wordToFind in wordsToFind)
                {

                    int occurrences = currentWords.Count(w => w == wordToFind);
                    wordsCount[wordToFind] += occurrences;
                }
            }

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var wordCount in wordsCount.OrderByDescending(w => w.Value))
            {
                stringBuilder.AppendLine($"{wordCount.Key} - {wordCount.Value}");
            }

            File.WriteAllText(outputFilePath, stringBuilder.ToString());
        }
    }
}
