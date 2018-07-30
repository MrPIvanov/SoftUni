using System;

public class Sword : Weapon
{
    public Sword(string rarity, string name) : base(rarity, name)
    {
        this.MinDMG = 4;
        this.MaxDMG = 6;
        this.SocketNumber = 3;
        this.Gems = new IGem[3];
    }
}