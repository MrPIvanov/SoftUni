namespace _05_FolderSize
{
    using System;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            var allFiles = Directory.GetFiles(@"D:\SoftUni\02-Progr Fund\21-Files and Exceptions\Resources\05. Folder Size\TestFolder\");
            var result = 0.0d;


            for (int i = 0; i < allFiles.Length; i++)
            {
                var info = new FileInfo(allFiles[i]);
                result += info.Length;
            }

            result /= 1024;
            result /= 1024;

            string resultStr = result.ToString();

            File.Delete(@"D:\SoftUni\02-Progr Fund\21-Files and Exceptions\HomeWorkResults\05-FolderSize.txt");

            File.AppendAllText(@"D:\SoftUni\02-Progr Fund\21-Files and Exceptions\HomeWorkResults\05-FolderSize.txt", resultStr);
           
        }

    }
}