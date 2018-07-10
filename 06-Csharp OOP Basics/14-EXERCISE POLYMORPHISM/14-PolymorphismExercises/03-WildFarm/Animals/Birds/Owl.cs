public class Owl : Bird
{
    public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
    {
    }

    public override void TryToEat(Animal currentAnimal, string[] foodArgs)
    {
        var foodName = foodArgs[0];
        var foodQuantity = int.Parse(foodArgs[1]);

        System.Console.WriteLine("Hoot Hoot");

        if (foodName == "Meat")
        {
            currentAnimal.FoodEaten += foodQuantity;
            currentAnimal.Weight += foodQuantity * 0.25d;
        }
        else
        {
            System.Console.WriteLine($"{currentAnimal.GetType()} does not eat {foodName}!");
        }
    }
}