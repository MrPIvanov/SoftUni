using System;

public abstract class Weapon : IWeapon
{
    public string Name { get;private set; }

    public int MinDMG { get; protected set; }

    public int MaxDMG { get; protected set; }

    public int SocketNumber { get; protected set; }

    public WeaponRarityEnum Rarity { get; protected set; }

    public IGem[] Gems { get; protected set; }

    public Weapon(string rarity, string name)
    {
        this.Rarity = (WeaponRarityEnum)Enum.Parse(typeof(WeaponRarityEnum), rarity);
        this.Name = name;
    }
}