namespace _04_AnonymousCache
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var allDataSetsNames = new List<string>();
            var allDataSetValues = new Dictionary<string,Dictionary<string,long>>();

            string input;
            while ((input = Console.ReadLine()) != "thetinggoesskrra")
            {
                var inputArgs = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                if (inputArgs.Length==1)
                {
                    if (!allDataSetsNames.Contains(input))
                    {
                        allDataSetsNames.Add(input);
                    }
                }
                else
                {
                    var secondPart = inputArgs[1].Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                    var dataKey = inputArgs[0];
                    var dataSize = long.Parse(secondPart[0]);
                    var dataSet = secondPart[1];

                    if (allDataSetValues.ContainsKey(dataSet))
                    {
                        allDataSetValues[dataSet].Add(dataKey, dataSize);
                    }
                    else
                    {
                        allDataSetValues[dataSet] = new Dictionary<string, long>();
                        allDataSetValues[dataSet].Add(dataKey, dataSize);
                    }

                }

            }
            var finalColection = allDataSetValues.Where(x => allDataSetsNames.Contains(x.Key)).ToDictionary(x=>x.Key,x=>x.Value);


            foreach (var item in finalColection.OrderByDescending(x=>x.Value.Values.Sum()))
            {
                Console.WriteLine($"Data Set: {item.Key}, Total Size: {item.Value.Values.Sum()}");
                foreach (var key in item.Value)
                {
                    Console.WriteLine($"$.{key.Key}");
                }
                break;
            }
           
        }
    }
}