public class Rebel : Person , IBuyer
{
    public Rebel(string name, int age, string group) : base(name, age)
    {
        Group = group;
    }

   
    public override void BuyFood()
    {
        FoodCount += 5;
    }
}