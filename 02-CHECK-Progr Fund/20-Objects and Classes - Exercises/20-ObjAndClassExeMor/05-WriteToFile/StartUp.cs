using System;
using System.IO;
using System.Linq;

namespace _05_WriteToFile
{
    public class StartUp
    {
        public static void Main()
        {
            var text = File.ReadAllText(@"D:\SoftUni\02-Progr Fund\20-Objects and Classes - Exercises\Resources\sample_text.txt");
            var chars = text.Where(c => ".,?!:".IndexOf(c) == -1).ToArray();

            Console.Write(string.Join("", chars));

        }
    }
}