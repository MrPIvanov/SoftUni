public class Amethyst : Gem
{
    public Amethyst(string rarity, int possition) : base(rarity, possition)
    {
    }

    public override int Strength => 2 + (int)this.Rarity;

    public override int Agility => 8 + (int)this.Rarity;

    public override int Vitality => 4 + (int)this.Rarity;

    
}