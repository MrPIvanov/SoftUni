public class Ruby : Gem
{
    public Ruby(string rarity, int possition) : base(rarity, possition)
    {
    }

    public override int Strength => 7 + (int)this.Rarity;

    public override int Agility => 2 + (int)this.Rarity;

    public override int Vitality => 5 + (int)this.Rarity;

}