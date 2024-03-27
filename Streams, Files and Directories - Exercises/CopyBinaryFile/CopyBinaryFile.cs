namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using FileStream reader = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read);
            using FileStream writer = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write);

            byte[] buffer = new byte[1024];
            int bytesReaded;

            while ((bytesReaded = reader.Read(buffer, 0, buffer.Length)) != 0)
            {
                writer.Write(buffer, 0, bytesReaded);
            }
        }
    }
}
