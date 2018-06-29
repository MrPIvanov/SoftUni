public class Dough
{
    private string flourType;
    private string bakingTechnique;
    private double weight;
    private double totalCal;

    private string FlourType
    {
        get { return flourType; }
        set
        {
            if (!(value.ToLower() == "white" || value.ToLower() == "wholegrain"))
            {
                throw new System.ArgumentException("Invalid type of dough.");
            }
            flourType = value;
        }
    }

    private string BakingTechnique
    {
        get { return bakingTechnique; }
        set
        {
            if (!(value.ToLower() == "crispy" || value.ToLower() == "chewy" || value.ToLower() == "homemade"))
            {
                throw new System.ArgumentException("Invalid type of dough.");
            }

            bakingTechnique = value;
        }
    }

    private double Weight
    {
        get { return weight; }
        set
        {
            if (value < 1 || value > 200)
            {
                throw new System.ArgumentException("Dough weight should be in the range [1..200].");
            }
            weight = value;
        }
    }

    public double TotalCal
    {
        get { return totalCal; }
        private set { totalCal = value; }
    }

    public Dough(string flourType, string bakingTechnique, double weight)
    {
        FlourType = flourType;
        BakingTechnique = bakingTechnique;
        Weight = weight;
    }

    public void CalculateTotalCal()
    {
        var flourModifier = 1.0d;
        var bakingModifier = 1.0d;

        if (FlourType.ToLower() == "white")
        {
            flourModifier = 1.5d;
        }
        if (BakingTechnique.ToLower() == "crispy")
        {
            bakingModifier = 0.9d;
        }
        if (BakingTechnique.ToLower() == "chewy")
        {
            bakingModifier = 1.1d;
        }

        TotalCal = (2 * Weight) * flourModifier * bakingModifier;
    }

}