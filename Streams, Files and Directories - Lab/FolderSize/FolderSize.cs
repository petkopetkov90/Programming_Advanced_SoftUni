namespace FolderSize
{
    using System;
    using System.IO;
    using System.Runtime.InteropServices;

    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {

            //DirectoryInfo directory = new DirectoryInfo(folderPath);
            //FileInfo[] filesInfo = directory.GetFiles("*", SearchOption.AllDirectories);
            //long sum = 0;

            //foreach (var fileInfo in filesInfo)
            //{
            //    sum += fileInfo.Length;
            //}

            //File.WriteAllText(outputFilePath,$"{(double)sum / 1024}");


            long size = GetFilesSize(folderPath);
            double kb = (double)size / 1024;

            File.WriteAllText(outputFilePath, $"{kb}");

            static long GetFilesSize(string folderPath)
            {
                string[] files = Directory.GetFiles(folderPath);
                long size = 0;

                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    size += fileInfo.Length;
                }

                string[] directories = Directory.GetDirectories(folderPath);

                foreach (string directory in directories)
                {
                    size += GetFilesSize(directory);
                }

                return size;
            }
        }
    }
}
