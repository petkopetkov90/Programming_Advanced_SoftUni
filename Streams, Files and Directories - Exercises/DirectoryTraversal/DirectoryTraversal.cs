namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(inputFolderPath);
            FileInfo[] files = directoryInfo.GetFiles();
            SortedDictionary<string, Dictionary<string, double>> extensionsFiles = new SortedDictionary<string, Dictionary<string, double>>();

            foreach (var file in files)
            {
                string extrension = Path.GetExtension(file.FullName);
                string fileName = Path.GetFileName(file.FullName);
                double fileSize = (double)file.Length / 1024;

                if (!extensionsFiles.ContainsKey(extrension))
                {
                    extensionsFiles.Add(extrension, new Dictionary<string, double>());
                }

                extensionsFiles[extrension].Add(fileName, fileSize);
            }

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var extensionKVP in extensionsFiles.OrderByDescending(ex => ex.Value.Count()))
            {
                stringBuilder.AppendLine(extensionKVP.Key);

                foreach (var fileKVP in extensionKVP.Value.OrderBy(f => f.Value))
                {
                    stringBuilder.AppendLine($"--{fileKVP.Key} - {fileKVP.Value}kb");
                }
            }

            return stringBuilder.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            File.WriteAllText(desktopPath, textContent);
        }
    }
}
