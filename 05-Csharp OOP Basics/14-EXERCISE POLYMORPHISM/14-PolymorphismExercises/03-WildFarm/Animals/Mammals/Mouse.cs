public class Mouse : Mammal
{
    public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
    {
    }

    public override void TryToEat(Animal currentAnimal, string[] foodArgs)
    {
        var foodName = foodArgs[0];
        var foodQuantity = int.Parse(foodArgs[1]);

        System.Console.WriteLine("Squeak");

        if (foodName == "Vegetable" || foodName == "Fruit")
        {
            currentAnimal.FoodEaten += foodQuantity;
            currentAnimal.Weight += foodQuantity * 0.1d;
        }
        else
        {
            System.Console.WriteLine($"{currentAnimal.GetType()} does not eat {foodName}!");
        }
    }
}