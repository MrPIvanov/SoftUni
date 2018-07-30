using System;

public abstract class Gem : IGem
{
    public Gem(string rarity, int possition)
    {
        this.Rarity = (GemRarityEnum)Enum.Parse(typeof(GemRarityEnum), rarity);
        this.Possition = possition;
    }

    public abstract int Strength { get;}

    public abstract int Agility { get;}

    public abstract int Vitality { get; }

    public int Possition { get; set; }

    public GemRarityEnum Rarity { get; set;}
}