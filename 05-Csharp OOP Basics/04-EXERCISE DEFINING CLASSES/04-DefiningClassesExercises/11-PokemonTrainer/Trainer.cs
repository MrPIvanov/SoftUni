using System.Collections.Generic;

public class Trainer
{
    public string Name { get; set; }
    public int Badges { get; set; }
    public List<Pokemon> Pokemons { get; set; }

    public Trainer(string trainerName)
    {
        Name = trainerName;
        Badges = 0;
        Pokemons = new List<Pokemon>();
    }


    public void AddPokemon(Pokemon currentPokemon)
    {
        Pokemons.Add(currentPokemon);
    }

    public void AddBadge()
    {
        Badges++;
    }
}