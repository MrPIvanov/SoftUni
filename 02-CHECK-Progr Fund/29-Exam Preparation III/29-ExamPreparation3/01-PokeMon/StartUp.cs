namespace _01_PokeMon
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var pokePower = long.Parse(Console.ReadLine());
            var distanceBetweenTargets = long.Parse(Console.ReadLine());
            var exhaustionFactor = long.Parse(Console.ReadLine());
            var halfPokePower = 0.5m * pokePower;
            var countPokes = 0;

            while (true)
            {
                if (halfPokePower==pokePower && exhaustionFactor !=0)
                {
                    pokePower = pokePower / exhaustionFactor;
                }

                if (pokePower>=distanceBetweenTargets)
                {
                    countPokes++;
                    pokePower -= distanceBetweenTargets;
                }
                else
                {
                    break;
                }

            }

            Console.WriteLine(pokePower);
            Console.WriteLine(countPokes);
        }
    }
}