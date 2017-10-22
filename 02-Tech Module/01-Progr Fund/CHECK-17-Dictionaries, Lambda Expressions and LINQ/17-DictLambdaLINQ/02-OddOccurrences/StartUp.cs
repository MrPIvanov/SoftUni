namespace _02_OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToLower();

            List<string> inputList = input.Split().ToList();
            var result = new Dictionary<string, double>();

            for (int i = 0; i < inputList.Count; i++)
            {
                if (result.ContainsKey(inputList[i]))
                {
                    result[inputList[i]]++;
                }
                else
                {
                    result[inputList[i]] = 1;
                }
            }

            var endEesult = new List<string>();

            foreach (var item in result.Where(x => x.Value % 2 == 1))
            {
                endEesult.Add(item.Key);

            }
            Console.WriteLine(string.Join(", ", endEesult));
        }
    }
}