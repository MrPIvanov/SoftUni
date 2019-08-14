namespace _04_MergeFiles
{
    using System;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            var firstFile = File.ReadAllLines(@"D:\SoftUni\02-Progr Fund\21-Files and Exceptions\Resources\04. Merge Files\FileOne.txt");
            var secondFile = File.ReadAllLines(@"D:\SoftUni\02-Progr Fund\21-Files and Exceptions\Resources\04. Merge Files\FileTwo.txt");

            File.Delete(@"D:\SoftUni\02-Progr Fund\21-Files and Exceptions\HomeWorkResults\04-MergeFiles.txt");

            for (int i = 0; i < firstFile.Length; i++)
            {
                var linesToAppend = $"{firstFile[i]}{Environment.NewLine}{secondFile[i]}{Environment.NewLine}";

                File.AppendAllText(@"D:\SoftUni\02-Progr Fund\21-Files and Exceptions\HomeWorkResults\04-MergeFiles.txt", linesToAppend);

            }
        }
    }
}