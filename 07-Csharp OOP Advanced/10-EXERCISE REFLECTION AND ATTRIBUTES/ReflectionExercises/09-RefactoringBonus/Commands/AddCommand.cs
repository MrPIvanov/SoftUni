using System.Linq;

public class AddCommand : Command
{
    [InjectDependency]
    private IRepository Repository;

    [InjectDependency]
    private IGemFactory GemFactory;

    public AddCommand(string[] data, IRepository repository, IGemFactory gemFactory) : base(data)
    {
        this.Repository = repository;
        this.GemFactory = gemFactory;
    }

    public override void Execute()
    {
        var gem = this.GemFactory.CreateGem(this.Data);

        var weaponToAdd = this.Repository.Weapons.FirstOrDefault(w=>w.Name==this.Data[0]);

        this.Repository.Add(weaponToAdd, gem);
    }
}