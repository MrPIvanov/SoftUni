namespace _04_PokemonEvolution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var allPokemonNames = new List<string>();
            var pokemons = new List<Pokemon>();

            string input;
            while ((input=Console.ReadLine()) != "wubbalubbadubdub")
            {
                var args = input.Split(new string[] { " -> " },StringSplitOptions.RemoveEmptyEntries);

                if (args.Length>1)
                {
                    var currentPokemon = new Pokemon();
                    currentPokemon.Name = args[0];
                    currentPokemon.Type = args[1];
                    currentPokemon.Evolution = long.Parse(args[2]);

                    pokemons.Add(currentPokemon);

                    if (!allPokemonNames.Contains(args[0]))
                    {
                        allPokemonNames.Add(args[0]);
                    }

                }
                else
                {
                    if (allPokemonNames.Contains(args[0]))
                    {
                        var tempName = args[0];
                        PrintPokemonsTemp(tempName, pokemons);
                    }
                }

            }

            PrintPokemonsFinal(allPokemonNames,pokemons);
        }

        private static void PrintPokemonsTemp(string tempName, List<Pokemon> pokemons)
        {
            Console.WriteLine($"# {tempName}");
            foreach (var pokemon in pokemons.Where(x=>x.Name==tempName))
            {
                Console.WriteLine($"{pokemon.Type} <-> {pokemon.Evolution}");
            }
        }

        private static void PrintPokemonsFinal(List<string> allPokemonNames, List<Pokemon> pokemons)
        {
            foreach (var pokemonName in allPokemonNames)
            {
                Console.WriteLine($"# {pokemonName}");
                foreach (var type in pokemons.Where(x=>x.Name==pokemonName).OrderByDescending(x=>x.Evolution))
                {
                    Console.WriteLine($"{type.Type} <-> {type.Evolution}");
                }
            }
        }
    }

    public class Pokemon
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public long Evolution { get; set; }

    }
}