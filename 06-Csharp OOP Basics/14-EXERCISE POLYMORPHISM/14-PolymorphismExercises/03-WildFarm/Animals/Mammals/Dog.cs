public class Dog : Mammal
{
    public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
    {
    }

    public override void TryToEat(Animal currentAnimal, string[] foodArgs)
    {
        var foodName = foodArgs[0];
        var foodQuantity = int.Parse(foodArgs[1]);

        System.Console.WriteLine("Woof!");

        if (foodName == "Meat")
        {
            currentAnimal.FoodEaten += foodQuantity;
            currentAnimal.Weight += foodQuantity * 0.4d;
        }
        else
        {
            System.Console.WriteLine($"{currentAnimal.GetType()} does not eat {foodName}!");
        }
    }
}