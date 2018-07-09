public abstract class Person : IBuyer
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Id { get; set; }
    public string Birthdate { get; set; }
    public string Group { get; set; }
    public int FoodCount { get; set; }

    public Person(string name,int age)
    {
        Name = name;
        Age = age;
        FoodCount = 0;
    }

    public virtual void BuyFood()
    {
    }
}