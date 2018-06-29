using System.Collections.Generic;

public class Pizza
{
    private string name;
    private Dough dough;
    private List<Topping> toppings;
    private double totalCal;

    public double TotalCal
    {
        get { return totalCal; }
        private set { totalCal = value; }
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new System.ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
            else if (value.Length>15)
            {
                throw new System.ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
            name = value;
        }
    }

    public Dough Dough
    {
        get { return dough; }
        set { dough = value; }
    }

    private List<Topping> Toppings
    {
        get { return toppings; }
        set { toppings = value; }
    }

    public Pizza(string name)
    {
        Name = name;
        Toppings = new List<Topping>();
    }

    public void AddTopping(Topping topping)
    {
        if (Toppings.Count==10)
        {
            throw new System.ArgumentException("Number of toppings should be in range [0..10].");
        }
        Toppings.Add(topping);
    }
    public void CalculateTotalCal()
    {
        var temp = 0.0d;
        foreach (var topping in Toppings)
        {
            topping.CalculateCal();
            temp += topping.TotalCal;
        }
        Dough.CalculateTotalCal();
        temp += Dough.TotalCal;
        TotalCal = temp;
    }
}