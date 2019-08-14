namespace _01_OddLines
{
    using System;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            var allLines = File.ReadAllLines(@"D:\SoftUni\02-Progr Fund\21-Files and Exceptions\Resources\01. Odd Lines\input.txt");

            File.Delete(@"D:\SoftUni\02-Progr Fund\21-Files and Exceptions\HomeWorkResults\01-OddLines.txt");

            for (int i = 1; i <= allLines.Length; i += 2)
            {
                File.AppendAllText(@"D:\SoftUni\02-Progr Fund\21-Files and Exceptions\HomeWorkResults\01-OddLines.txt", allLines[i]);
                File.AppendAllText(@"D:\SoftUni\02-Progr Fund\21-Files and Exceptions\HomeWorkResults\01-OddLines.txt", Environment.NewLine);
            }


        }
    }
}