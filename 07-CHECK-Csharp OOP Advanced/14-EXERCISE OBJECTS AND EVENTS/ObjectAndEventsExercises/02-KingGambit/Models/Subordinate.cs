public abstract class Subordinate : ISubordinate
{
    public int LifePoints { get; set; }

    public string Name { get; set; }

    protected Subordinate(string name, int lifePoints)
    {
        this.Name = name;
        this.LifePoints = lifePoints;
    }

    public void TakeDamage()
    {
        this.LifePoints--;
    }

    public abstract void ReactToAtack();
}