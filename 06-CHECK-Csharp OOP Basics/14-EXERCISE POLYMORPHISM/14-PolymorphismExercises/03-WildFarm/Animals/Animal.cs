public abstract class Animal
{
    public string Name { get;  set; }
    public double Weight { get;  set; }
    public int FoodEaten { get;  set; }

    public Animal(string name,double weight)
    {
        this.Name = name;
        this.Weight = weight;
        this.FoodEaten = 0;
    }

    public abstract void TryToEat(Animal currentAnimal, string[] foodArgs);

    public override string ToString()
    {
        return $" [{this.Name}, ";
    }
}