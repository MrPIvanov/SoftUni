using System;

public class Axe : Weapon
{
    public Axe(string rarity, string name) : base(rarity, name)
    {
        this.MinDMG = 5;
        this.MaxDMG = 10;
        this.SocketNumber = 4;
        this.Gems = new IGem[4];
    }
}