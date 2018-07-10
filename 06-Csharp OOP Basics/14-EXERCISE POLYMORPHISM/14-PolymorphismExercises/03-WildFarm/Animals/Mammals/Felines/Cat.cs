public class Cat : Feline
{
    public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
    {
    }

    public override void TryToEat(Animal currentAnimal, string[] foodArgs)
    {
        var foodName = foodArgs[0];
        var foodQuantity = int.Parse(foodArgs[1]);

        System.Console.WriteLine("Meow");

        if (foodName == "Meat" || foodName == "Vegetable")
        {
            currentAnimal.FoodEaten += foodQuantity;
            currentAnimal.Weight += foodQuantity * 0.3d;
        }
        else
        {
            System.Console.WriteLine($"{currentAnimal.GetType()} does not eat {foodName}!");
        }
    }
}