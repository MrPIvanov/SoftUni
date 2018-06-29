public class Topping
{
    private string type;
    private double weight;
    private double totalCal;

    private string Type
    {
        get { return type; }
        set
        {
            if (!(value.ToLower()=="meat" || value.ToLower() == "veggies" || value.ToLower() == "cheese" || value.ToLower() == "sauce"))
            {
                throw new System.ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            type = value;
        }
    }

    private double Weight
    {
        get { return weight; }
        set
        {
            if (value<1 || value > 50)
            {
                throw new System.ArgumentException($"{Type} weight should be in the range [1..50].");
            }
            weight = value;
        }
    }

    public double TotalCal
    {
        get { return totalCal; }
        private set { totalCal = value; }
    }

    public Topping(string type,double weight)
    {
        Type = type;
        Weight = weight;
    }

    public void CalculateCal()
    {
        var typeModifier = 1.2d;

        if (Type.ToLower() == "veggies")
        {
            typeModifier = 0.8d;
        }
        if (Type.ToLower() == "cheese")
        {
            typeModifier = 1.1d;
        }
        if (Type.ToLower() == "sauce")
        {
            typeModifier = 0.9d;
        }

        TotalCal = (2 * Weight) * typeModifier;
    }
}