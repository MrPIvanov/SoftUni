using System.Collections.Generic;

public delegate void KingUnderAtack();

public class King : IKing
{
    public event KingUnderAtack KingTakeAtackEvent;

    private ICollection<ISubordinate> subordinates;

    public King(string name)
    {
        this.Name = name;
        this.subordinates = new List<ISubordinate>();
    }

    public IReadOnlyCollection<ISubordinate> Subordinates => (IReadOnlyCollection<ISubordinate>)this.subordinates;

    public string Name { get; }

    public void AddSubordinate(ISubordinate subordinate)
    {
        this.subordinates.Add(subordinate);
        KingTakeAtackEvent += subordinate.ReactToAtack;
    }

    public void RemoveSubordinate(ISubordinate subordinate)
    {
        KingTakeAtackEvent -= subordinate.ReactToAtack;
        this.subordinates.Remove(subordinate);
    }

    public void TakeAtack()
    {
        System.Console.WriteLine($"King {this.Name} is under attack!");

        if (KingTakeAtackEvent != null)
        {
            this.KingTakeAtackEvent.Invoke();
        }
    }
}