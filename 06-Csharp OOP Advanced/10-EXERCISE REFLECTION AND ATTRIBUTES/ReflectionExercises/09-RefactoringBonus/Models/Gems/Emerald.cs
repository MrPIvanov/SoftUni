public class Emerald : Gem
{
    public Emerald(string rarity, int possition) : base(rarity, possition)
    {
    }

    public override int Strength => 1 + (int)this.Rarity;

    public override int Agility => 4 + (int)this.Rarity;

    public override int Vitality => 9 + (int)this.Rarity;


}