namespace _09_LegenFarm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var result = new SortedDictionary<string,int>();
            result.Add("shards",0);
            result.Add("fragments", 0);
            result.Add("motes", 0);

            var junkResult = new SortedDictionary<string, int>();


            while (true)
            {
                var input = Console.ReadLine().ToLower().Split().ToArray();

                for (int i = 0; i < input.Length; i+=2)
                {
                    if (result.ContainsKey(input[i + 1]))
                    {
                        result[input[i + 1]] += int.Parse(input[i]);

                        int shadowmourneShards = 0;
                        int valanyrFragments = 0;
                        int dragonwrathMotes = 0;


                        result.TryGetValue("shards", out shadowmourneShards);
                        result.TryGetValue("fragments", out valanyrFragments);
                        result.TryGetValue("motes", out dragonwrathMotes);

                        if (shadowmourneShards >= 250)
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            result["shards"] -= 250;
                            PrintResults(result);
                            PrintJunk(junkResult);
                            return;
                        }
                        else if (valanyrFragments >= 250)
                        {
                            Console.WriteLine("Valanyr obtained!");
                            result["fragments"] -= 250;
                            PrintResults(result);
                            PrintJunk(junkResult);
                            return;

                        }
                        else if (dragonwrathMotes >= 250)
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            result["motes"] -= 250;
                            PrintResults(result);
                            PrintJunk(junkResult);
                            return;
                        }
                    }
                    else
                    {
                        if (junkResult.ContainsKey(input[i+1]))
                        {
                            junkResult[input[i + 1]] += int.Parse(input[i]);

                        }
                        else
                        {
                            junkResult.Add(input[i+1],int.Parse(input[i]));
                        }
                    }
                    
                }
               

            }


        }

        public static void PrintJunk(SortedDictionary<string, int> junkResult)
        {
            foreach (var item in junkResult)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        public static void PrintResults(SortedDictionary<string, int> results)
        {
            foreach (var item in results.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}