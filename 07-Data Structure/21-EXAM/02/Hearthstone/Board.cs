using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Board : IBoard
{
    private Dictionary<string, Card> allCards = new Dictionary<string, Card>();

    public bool Contains(string name)
    {
        return this.allCards.ContainsKey(name);
    }

    public int Count()
    {
        return this.allCards.Count;
    }

    public void Draw(Card card)
    {
        if (this.Contains(card.Name))
        {
            throw new ArgumentException();
        }

        this.allCards[card.Name] = card;
    }

    public IEnumerable<Card> GetBestInRange(int start, int end)
    {
        return this.allCards.Values.Where(x => x.Score >= start && x.Score <= end).OrderByDescending(x => x.Level);
    }

    public void Heal(int health)
    {
        this.allCards.Values.OrderBy(x => x.Health).FirstOrDefault().Health += health; // ??? performance
    }

    public IEnumerable<Card> ListCardsByPrefix(string prefix)
    {
        var result = this.allCards.Values.Where(x => x.Name.StartsWith(prefix));

        return result.OrderBy(x => string.Join("", x.Name.ToCharArray().Reverse())).ThenBy(x => x.Level);

    }

    public void Play(string attackerCardName, string attackedCardName)
    {
        if (!this.allCards.ContainsKey(attackerCardName))
        {
            throw new ArgumentException();
        }

        if (!this.allCards.ContainsKey(attackedCardName))
        {
            throw new ArgumentException();
        }

        var atacker = this.allCards[attackerCardName];
        var defender = this.allCards[attackedCardName];

        if (atacker.Level != defender.Level)
        {
            throw new ArgumentException();
        }


        //Chech for current health and can you play???

        if (defender.Health > 0)
        {

            if (atacker.Damage >= defender.Health)
            {
                atacker.Score += defender.Level;
            }

            defender.Health -= atacker.Damage;

        }


    }

    public void Remove(string name)
    {
        if (!this.allCards.ContainsKey(name))
        {
            throw new ArgumentException();
        }
        this.allCards.Remove(name);
    }

    public void RemoveDeath()
    {
        var allNames = this.allCards.Values.Where(x => x.Health <= 0).Select(x => x.Name).ToArray();

        for (int i = 0; i < allNames.Length; i++)
        {
            this.Remove(allNames[i]);
        }

    }

    public IEnumerable<Card> SearchByLevel(int level)
    {
        return this.allCards.Values.Where(x => x.Level == level).OrderByDescending(x => x.Score);
    }
}