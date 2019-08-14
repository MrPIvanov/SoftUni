using System.Linq;

public class RemoveCommand : Command
{
    [InjectDependency]
    private IRepository Repository;

    public RemoveCommand(string[] data, IRepository repository) : base(data)
    {
        this.Repository = repository;
    }

    public override void Execute()
    {
        var weapon = this.Repository.Weapons.Where(w => w.Name == this.Data[0]).FirstOrDefault();
        this.Repository.Remove(weapon, int.Parse(this.Data[1]));
    }
}