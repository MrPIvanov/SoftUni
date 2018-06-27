using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        var allTrainers = new List<Trainer>();

        string input;
        while ((input = Console.ReadLine().Trim()) != "Tournament")
        {
            var currentPokemon = new Pokemon(input);
            var args = input.Split();
            var trainerName = args[0];
            var currentTrainer = new Trainer(trainerName);


            if (allTrainers.Any(x=>x.Name==trainerName))
            {
                allTrainers.Where(x => x.Name == trainerName).First().AddPokemon(currentPokemon);
            }
            else
            {
                allTrainers.Add(currentTrainer);
                currentTrainer.AddPokemon(currentPokemon);
            }
        }

        string elementInput;
        while ((elementInput = Console.ReadLine().Trim()) != "End")
        {
            foreach (var trainer in allTrainers)
            {
                if (trainer.Pokemons.Any(x=>x.Element==elementInput))
                {
                    trainer.AddBadge();
                }
                else
                {
                    foreach (var poke in trainer.Pokemons)
                    {
                        poke.Health -= 10;
                    }
                    foreach (var trainerr in allTrainers)
                    {
                        trainerr.Pokemons.RemoveAll(x => x.Health <= 0);
                    }
                }
            }

            

        }

        foreach (var trainer in allTrainers.OrderByDescending(x=>x.Badges))
        {

            Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count()}");
        }

    }
}