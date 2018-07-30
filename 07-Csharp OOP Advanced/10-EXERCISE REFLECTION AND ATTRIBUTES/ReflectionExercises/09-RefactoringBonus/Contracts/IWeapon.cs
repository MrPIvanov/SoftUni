public interface IWeapon
{
    string Name { get; }
    int MinDMG { get; }
    int MaxDMG { get; }
    int SocketNumber { get; }
    WeaponRarityEnum Rarity { get; }
    IGem[] Gems { get; }
}