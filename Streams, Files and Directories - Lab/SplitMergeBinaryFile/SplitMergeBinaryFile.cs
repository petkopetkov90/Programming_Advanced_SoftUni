namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            byte[] inputBytes = File.ReadAllBytes(sourceFilePath);
            byte[] firstPartBytes = inputBytes.Take((inputBytes.Length + 1) / 2).ToArray();
            byte[] secondPartBytes = inputBytes.Skip((inputBytes.Length + 1) / 2).ToArray();
            File.WriteAllBytes(partOneFilePath, firstPartBytes);
            File.WriteAllBytes(partTwoFilePath, secondPartBytes);
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            byte[] firstPart = File.ReadAllBytes(partOneFilePath);
            byte[] secondPart = File.ReadAllBytes(partTwoFilePath);
            using FileStream writer = File.OpenWrite(joinedFilePath);
            writer.Write(firstPart, 0, firstPart.Length);
            writer.Write(secondPart, 0, secondPart.Length);
        }
    }
}