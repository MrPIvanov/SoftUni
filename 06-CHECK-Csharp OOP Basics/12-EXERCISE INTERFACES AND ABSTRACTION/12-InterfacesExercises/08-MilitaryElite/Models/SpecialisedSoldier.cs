public abstract class SpecialisedSoldier : Private, ISoldier, IPrivate, ISpecialisedSoldier
{
    public string Corps { get;protected set; }

    public SpecialisedSoldier(string firstName, string lastName, string id, decimal salary,string corps) : base(firstName, lastName, id, salary)
    {
        Corps = corps;
    }
}