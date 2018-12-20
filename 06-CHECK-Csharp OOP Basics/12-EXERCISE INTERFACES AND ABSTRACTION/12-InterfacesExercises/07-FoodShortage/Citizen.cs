public class Citizen : Person, IBuyer
{
    public Citizen(string name, int age,string id,string birthdate) : base(name, age)
    {
        Id = id;
        Birthdate = birthdate;
    }

    public override void BuyFood()
    {
        FoodCount += 10;
    }
}