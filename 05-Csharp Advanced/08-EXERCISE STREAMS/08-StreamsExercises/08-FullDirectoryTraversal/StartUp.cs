namespace _08_FullDirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var resultCollection = new Dictionary<string, Dictionary<string, double>>();

            var mainDir = @"D:\SoftUni\05-Csharp Advanced\08-EXERCISE STREAMS";

            var allDirs = new Queue<string>();
            allDirs.Enqueue(mainDir);
            
            GetAllDirs(resultCollection,allDirs);

            PrintResults(resultCollection);
        }

        private static void GetAllDirs(Dictionary<string, Dictionary<string, double>> resultCollection, Queue<string> allDirs)
        {
            if (allDirs.Count == 0 || allDirs ==null)
            {
                return;
            }

            GetAllFilesFromDir(resultCollection, allDirs.Peek());

            var subDirs = Directory.GetDirectories(allDirs.Peek());
            foreach (var dir in subDirs)
            {
                allDirs.Enqueue(dir);
            }

            allDirs.Dequeue();

            GetAllDirs(resultCollection, allDirs);
        }

        private static void GetAllFilesFromDir(Dictionary<string, Dictionary<string, double>> resultCollection, string dirName)
        {
            var allFiles = Directory.GetFiles(dirName).ToList();

            foreach (var file in allFiles)
            {
                var info = new FileInfo(file);
                var extention = info.Extension;
                var name = info.Name;
                double size = info.Length / 1024d;

                if (resultCollection.ContainsKey(extention))
                {
                    if (resultCollection[extention].ContainsKey(name))
                    {
                        resultCollection[extention][name] += size;
                    }
                    else
                    {
                        resultCollection[extention].Add(name, size);
                    }
                }
                else
                {
                    resultCollection[extention] = new Dictionary<string, double>();
                    resultCollection[extention].Add(name, size);
                }
            }
        }

        private static void PrintResults(Dictionary<string, Dictionary<string, double>> resultCollection)
        {
            var reportPath = @"D:\SoftUni\05-Csharp Advanced\08-EXERCISE STREAMS\HomeWorkResults\08-DirectoryTraversal-Report.txt";
            File.Delete(reportPath);
            foreach (var file in resultCollection.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key))
            {
                File.AppendAllText(reportPath, $"{file.Key}{Environment.NewLine}");

                foreach (var fileName in file.Value.OrderBy(x => x.Value))
                {
                    File.AppendAllText(reportPath, $"--{fileName.Key} - {fileName.Value:f3}kb{Environment.NewLine}");
                }
            }
        }
    }
}