namespace _07_DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var allFiles = Directory.GetFiles(@"D:\SoftUni\05-Csharp Advanced\08-EXERCISE STREAMS\HomeWorkResults").ToList();

            var resultCollection = new Dictionary<string, Dictionary<string, double>>();

            foreach (var file in allFiles)
            {
                var info = new FileInfo(file);
                var extention = info.Extension;
                var name = info.Name;
                double size = info.Length/1024d;

                if (resultCollection.ContainsKey(extention))
                {
                    resultCollection[extention].Add(name, size);
                }
                else
                {
                    resultCollection[extention] = new Dictionary<string, double>();
                    resultCollection[extention].Add(name, size);
                }
            }

            var reportPath = @"D:\SoftUni\05-Csharp Advanced\08-EXERCISE STREAMS\HomeWorkResults\07-DirectoryTraversal-Report.txt";
            File.Delete(reportPath);
            foreach (var file in resultCollection.OrderByDescending(x=>x.Value.Count()).ThenBy(x=>x.Key))
            {
                File.AppendAllText(reportPath, $"{file.Key}{Environment.NewLine}");

                foreach (var fileName  in file.Value.OrderBy(x=>x.Value))
                {
                    File.AppendAllText(reportPath, $"--{fileName.Key} - {fileName.Value:f3}kb{Environment.NewLine}");
                }
            }
            
        }
    }
}