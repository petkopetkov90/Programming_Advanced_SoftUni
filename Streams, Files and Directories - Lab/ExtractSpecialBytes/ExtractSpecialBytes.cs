namespace ExtractSpecialBytes
{
    using System;
    using System.IO;
    using System.Linq;

    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            byte[] bytesToSearch = File.ReadAllLines(bytesFilePath).Select(byte.Parse).ToArray();

            byte[] bytesFromFile = File.ReadAllBytes(binaryFilePath);

            byte[] bytesOccurences =  bytesFromFile.Where(b => bytesToSearch.Contains(b)).ToArray();
        }
    }
}

