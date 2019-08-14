using System.Collections.Generic;

public interface IKing : INameable
{
    IReadOnlyCollection<ISubordinate> Subordinates { get; }

    void TakeAtack();

    void AddSubordinate(ISubordinate subordinate);

    void RemoveSubordinate(ISubordinate subordinate);
}