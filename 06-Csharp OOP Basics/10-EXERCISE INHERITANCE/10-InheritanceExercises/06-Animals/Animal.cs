using System.Text;

public class Animal : ISoundProducable
{
    private string name;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
            {
                throw new System.ArgumentException("Invalid input!");
            }
            name = value;
        }
    }

    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (string.IsNullOrWhiteSpace(value.ToString()) || value <=0)
            {
                throw new System.ArgumentException("Invalid input!");
            }
            age = value;
        }
    }
    private string gender;

    public string Gender
    {
        get { return gender; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
            {
                throw new System.ArgumentException("Invalid input!");
            }
            gender = value;
        }
    }

    public Animal(string name,int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }
    public virtual string ProduceSound()
    {
        return  "Default";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.GetType().Name}");
        sb.AppendLine($"{Name} {Age} {Gender}");
        sb.AppendLine($"{ProduceSound()}");

        var result = sb.ToString().TrimEnd();
        return result;
    }
}