using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

public class RoyaleArena : IArena
{
    private Dictionary<int, Battlecard> byId = new Dictionary<int, Battlecard>();
    private Dictionary<string, OrderedBag<Battlecard>> byName = new Dictionary<string, OrderedBag<Battlecard>>();

    public int Count => this.byId.Count;

    public void Add(Battlecard card)
    {
        if (!this.Contains(card))
        {
            this.byId[card.Id] = card;
        }

        if (!this.byName.ContainsKey(card.Name))
        {
            this.byName[card.Name] = new OrderedBag<Battlecard>((x, y) => y.Swag.CompareTo(x.Swag));
        }
        this.byName[card.Name].Add(card);
    }

    public void ChangeCardType(int id, CardType type)
    {
        if (!this.byId.ContainsKey(id))
        {
            throw new ArgumentException();
        }
        this.byId[id].Type = type;
    }

    public bool Contains(Battlecard card)
    {
        return this.byId.ContainsKey(card.Id);
    }

    public IEnumerable<Battlecard> FindFirstLeastSwag(int n)
    {
        if (n > this.Count)
        {
            throw new InvalidOperationException();
        }
        return this.byId.Values.OrderBy(x => x.Swag).ThenBy(x => x.Id).Take(n);
    }

    public IEnumerable<Battlecard> GetAllByNameAndSwag() 
    {
        var result = new List<Battlecard>();

        foreach (var item in this.byName)
        {
            result.Add(item.Value[0]);
        }
        return result;
    }

    public IEnumerable<Battlecard> GetAllInSwagRange(double lo, double hi)
    {
        return this.byId.Values.Where(x => x.Swag >= lo && x.Swag <= hi).OrderBy(x => x.Swag);
    }

    public IEnumerable<Battlecard> GetByCardType(CardType type)
    {
        var result = this.byId.Values.Where(x => x.Type == type).OrderByDescending(x => x.Damage).ThenBy(x => x.Id);

        if (result.Count() == 0)
        {
            throw new InvalidOperationException();
        }

        return result;
    }

    public IEnumerable<Battlecard> GetByCardTypeAndMaximumDamage(CardType type, double damage)
    {
        var result = this.byId.Values.Where(x => x.Type == type && x.Damage <= damage).OrderByDescending(x => x.Damage).ThenBy(x => x.Id);

        if (result.Count() == 0)
        {
            throw new InvalidOperationException();
        }

        return result;
    }

    public Battlecard GetById(int id)
    {
        if (!this.byId.ContainsKey(id))
        {
            throw new InvalidOperationException();
        }
        return this.byId[id];
    }

    public IEnumerable<Battlecard> GetByNameAndSwagRange(string name, double lo, double hi)
    {
        var result = this.byId.Values.Where(x => x.Name == name && x.Swag >= lo && x.Swag < hi).OrderByDescending(x => x.Swag).ThenBy(x => x.Id);

        if (result.Count() == 0)
        {
            throw new InvalidOperationException();
        }

        return result;
    }

    public IEnumerable<Battlecard> GetByNameOrderedBySwagDescending(string name)
    {
        var result = this.byId.Values.Where(x => x.Name == name).OrderByDescending(x => x.Swag).ThenBy(x => x.Id);

        if (result.Count() == 0)
        {
            throw new InvalidOperationException();
        }

        return result;
    }

    public IEnumerable<Battlecard> GetByTypeAndDamageRangeOrderedByDamageThenById(CardType type, int lo, int hi)
    {
        var result = this.byId.Values.Where(x => x.Type == type && x.Damage > lo && x.Damage <= hi).OrderByDescending(x => x.Damage).ThenBy(x => x.Id);

        if (result.Count() == 0)
        {
            throw new InvalidOperationException();
        }

        return result;
    }

    public IEnumerator<Battlecard> GetEnumerator()
    {
        foreach (var item in this.byId.Values)
        {
            yield return item;
        }
    }

    public void RemoveById(int id)
    {
        var card = this.GetById(id);

        if (this.byId.ContainsKey(id))
        {
            this.byId.Remove(id);
        }
        else
        {
            throw new InvalidOperationException();
        }

        this.byName[card.Name].Remove(card);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
