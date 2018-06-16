using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03_CameraView
{
    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string text = Console.ReadLine();

            int skipElements = numbers[0];
            int takeElements = numbers[1];

            Regex reg = new Regex(@"[|][<]");
            List<string> result = new List<string>();

            string[] frames = reg.Split(text);

            for (int i = 1; i < frames.Length; i++)
            {
                if (frames[i].Length>=skipElements)
                {
                    char[] temp = frames[i].ToCharArray();
                    char[] temp2 = temp.Skip(skipElements).Take(takeElements).ToArray();
                    string tempString = new string(temp2);
                   
                    result.Add(tempString);

                }


            }


            Console.WriteLine(string.Join(", ",result));
        }
    }
}