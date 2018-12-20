public class Validator
{
    public void ValidateName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new System.ArgumentException("Name cannot be empty");
        }
    }

    public void ValidateMoney(decimal money)
    {
        if (money<0)
        {
            throw new System.ArgumentException("Money cannot be negative");
        }

    }
}