public interface ISubordinate : IMortal, INameable
{
    int LifePoints { get; }

    void ReactToAtack();
}