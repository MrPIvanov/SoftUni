using System;

public class Knife : Weapon
{
    public Knife(string rarity, string name) : base(rarity, name)
    {
        this.MinDMG = 3;
        this.MaxDMG = 4;
        this.SocketNumber = 2;
        this.Gems = new IGem[2];
    }
}