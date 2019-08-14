namespace _07_PopulCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var countryCity = new Dictionary<string, Dictionary<string, long>>();

            string city = "";
            string country = "";
            long population = 0;

            while (true)
            {
                List<string> data = Console.ReadLine().Split('|').ToList();

                city = data[0];
                if (city == "report") break;

                country = data[1];
                population = long.Parse(data[2]);

                var cityPopulation = new Dictionary<string, long>();

                if (!countryCity.ContainsKey(country))
                {

                    cityPopulation[city] = population;

                    countryCity[country] = cityPopulation;

                }
                else
                {

                    cityPopulation = countryCity[country];

                    if (cityPopulation.ContainsKey(city))
                        cityPopulation[city] += population;
                    else
                        cityPopulation.Add(city, population);
                    
                }
            }

            foreach (var state in countryCity.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                List<long> sumOfTowns = state.Value.Select(x => x.Value).ToList();
                Console.WriteLine($"{state.Key} (total population: {sumOfTowns.Sum()})");

                Console.Write($"=>{string.Join("=>", state.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}: {x.Value}\r\n"))}");
            }
        }
    }
}