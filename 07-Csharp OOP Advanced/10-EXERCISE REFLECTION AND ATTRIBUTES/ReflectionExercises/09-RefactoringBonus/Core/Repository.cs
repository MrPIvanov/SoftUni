using System;
using System.Collections.Generic;

public class Repository : IRepository
{
    public List<IWeapon> Weapons { get; private set; }


    public Repository()
    {
        this.Weapons = new List<IWeapon>();
    }

    public void Add(IWeapon weapon, IGem gem)
    {
        if (gem.Possition >= 0 && gem.Possition < weapon.SocketNumber)
        {
            weapon.Gems[gem.Possition] = gem;
        }
    }

    public void Create(IWeapon weapon)
    {
        this.Weapons.Add(weapon);
    }

    public void Remove(IWeapon weapon, int gemIndex)
    {
        if (gemIndex >= 0 && gemIndex < weapon.SocketNumber)
        {
            weapon.Gems[gemIndex] = null;
        }
    }

    public void Print(IWeapon weapon)
    {
        var name = weapon.Name;

        var str = 0;
        var agility = 0;
        var vitality = 0;

        foreach (var gem in weapon.Gems)
        {
            if (gem==null)
            {
                continue;
            }
            str += gem.Strength;
            agility += gem.Agility;
            vitality += gem.Vitality;
        }

        var minDmg = (int)weapon.Rarity*weapon.MinDMG + 2*str + 1*agility;
        var maxDmg = (int)weapon.Rarity * weapon.MaxDMG + 3*str + 4*agility;
       

        Console.WriteLine($"{name}: {minDmg}-{maxDmg} Damage, +{str} Strength, +{agility} Agility, +{vitality} Vitality");
    }
}