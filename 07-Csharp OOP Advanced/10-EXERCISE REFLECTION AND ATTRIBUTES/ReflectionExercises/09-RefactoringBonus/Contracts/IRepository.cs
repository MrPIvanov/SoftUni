using System.Collections.Generic;

public interface IRepository
{
    List<IWeapon> Weapons { get;  }

    void Create(IWeapon weapon);
    void Add(IWeapon weapon, IGem gem);
    void Remove(IWeapon weapon, int gemIndex);
    void Print(IWeapon weapon);
}