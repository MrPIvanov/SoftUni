public interface IGem
{
    int Strength { get; }
    int Agility { get; }
    int Vitality { get; }
    int Possition { get; }
    GemRarityEnum Rarity { get; }
}