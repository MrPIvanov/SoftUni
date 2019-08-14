using System.Linq;

public class PrintCommand : Command
{
    [InjectDependency]
    private IRepository Repository;

    public PrintCommand(string[] data, IRepository repository) : base(data)
    {
        this.Repository = repository;
    }

    public override void Execute()
    {
        var weapon = this.Repository.Weapons.Where(w => w.Name == this.Data[0]).FirstOrDefault();
        this.Repository.Print(weapon);
    }
}