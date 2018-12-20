public class Product
{
    private string name;
    private decimal price;

    public string Name
    {
        get { return name; }
        set
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new System.ArgumentException("Name cannot be empty");
            }
            name = value;
        }
    }

    public decimal Price
    {
        get { return price; }
        set
        {
            if (value <= 0)
            {
                throw new System.ArgumentException("Money cannot be negative");
            }
            price = value;
        }
    }

    public Product(string name,decimal price)
    {
        Name = name;
        Price = price;
    }

}