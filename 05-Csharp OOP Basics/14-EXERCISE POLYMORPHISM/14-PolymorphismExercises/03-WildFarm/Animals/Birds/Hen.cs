public class Hen : Bird
{
    public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
    {
    }

    public override void TryToEat(Animal currentAnimal, string[] foodArgs)
    {
        var foodName = foodArgs[0];
        var foodQuantity = int.Parse(foodArgs[1]);

        System.Console.WriteLine("Cluck");

        currentAnimal.FoodEaten += foodQuantity;
        currentAnimal.Weight += foodQuantity * 0.35d;
    }
}