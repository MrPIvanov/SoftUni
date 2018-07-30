public class CreateCommand : Command
{
    [InjectDependency]
    private IRepository Repository;

    [InjectDependency]
    private IWeaponFactory WeaponFactory;

    public CreateCommand(string[] data, IRepository repository, IWeaponFactory weaponFactory) : base(data)
    {
        this.Repository = repository;
        this.WeaponFactory = weaponFactory;
    }

    public override void Execute()
    {
        var weapon = this.WeaponFactory.CreateWeapon(this.Data);
        this.Repository.Create(weapon);
    }
}