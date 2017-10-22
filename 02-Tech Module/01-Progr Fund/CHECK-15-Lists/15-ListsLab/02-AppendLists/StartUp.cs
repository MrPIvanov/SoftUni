namespace _02_AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split('|').ToList();

            List<string> result = new List<string>();

            for (int i = input.Count-1; i >=0; i--)
            {
                List<string> temp = input[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                result.AddRange(temp);

            }
            Console.WriteLine($"{string.Join(" ",result)}");

        }
    }
}