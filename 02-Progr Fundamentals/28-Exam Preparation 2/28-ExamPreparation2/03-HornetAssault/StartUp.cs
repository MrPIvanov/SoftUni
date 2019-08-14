namespace _03_HornetAssault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            var bees = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

            var beesResult = new List<long>();
            var counterSkipHornets = 0;

            foreach (var bee in bees)
            {
                var hornetsPower = hornets.Skip(counterSkipHornets).Sum();

                if (hornetsPower < bee)
                {
                    beesResult.Add(bee - hornetsPower);
                    counterSkipHornets++;
                }
                else if (hornetsPower == bee)
                {
                    counterSkipHornets++;
                }
            }

            if (beesResult.Count>0)
            {
                Console.WriteLine(string.Join(" ", beesResult));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets.Skip(counterSkipHornets)));

            }

        }
    }
}