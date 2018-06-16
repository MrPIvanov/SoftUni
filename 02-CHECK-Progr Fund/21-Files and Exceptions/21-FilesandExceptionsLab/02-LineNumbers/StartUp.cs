namespace _02_LineNumbers
{
    using System;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            var allLines = File.ReadAllLines(@"D:\SoftUni\02-Progr Fund\21-Files and Exceptions\Resources\02. Line Numbers\Input.txt");
            File.Delete(@"D:\SoftUni\02-Progr Fund\21-Files and Exceptions\HomeWorkResults\02-LineNumbers.txt");

            for (int i = 0; i < allLines.Length; i++)
            {
                var textToAppend = $"{i+1}. {allLines[i]}{Environment.NewLine}";
                File.AppendAllText(@"D:\SoftUni\02-Progr Fund\21-Files and Exceptions\HomeWorkResults\02-LineNumbers.txt", textToAppend);

            }


        }
    }
}