namespace OddLines
{
    using System.IO;
    using System.Runtime.Serialization;
    using System.Text;

    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            //string[] lines = File.ReadAllLines(inputFilePath);
            //int count = 0;
            //StringBuilder stringBuilder = new StringBuilder();

            //foreach (string line in lines)
            //{
            //    if (count++ % 2 == 1)
            //    {
            //        stringBuilder.AppendLine(line);
            //    }
            //}

            //File.WriteAllText(outputFilePath, stringBuilder.ToString());

            using StreamReader streamReader = new StreamReader(inputFilePath);
            string line;
            int count = 0;
            using StreamWriter streamWriter = new StreamWriter(outputFilePath);

            while ((line = streamReader.ReadLine()) != null)
            {
                if (count++ % 2 == 1)
                {
                    streamWriter.WriteLine(line);
                }
            }
        }
    }
}
