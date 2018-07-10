public class Tiger : Feline
{
    public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
    {
    }

    public override void TryToEat(Animal currentAnimal, string[] foodArgs)
    {
        var foodName = foodArgs[0];
        var foodQuantity = int.Parse(foodArgs[1]);

        System.Console.WriteLine("ROAR!!!");

        if (foodName == "Meat")
        {
            currentAnimal.FoodEaten += foodQuantity;
            currentAnimal.Weight += foodQuantity * 1.0d;
        }
        else
        {
            System.Console.WriteLine($"{currentAnimal.GetType()} does not eat {foodName}!");
        }
    }
}