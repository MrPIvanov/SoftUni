using System.Text;

public class Book
{
    private string author;
    private string title;
    private decimal price;

    public string Author
    {
        get { return author; }
        set
        {
            var indexOfSpace = value.IndexOf(' ');

            if (indexOfSpace > 0 && indexOfSpace < value.Length - 1 && char.IsDigit(value[indexOfSpace + 1]))
            {
                throw new System.ArgumentException("Author not valid!");
            }
            author = value;
        }
    }

    public string Title
    {
        get { return title; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length<3)
            {
                throw new System.ArgumentException("Title not valid!");
            }
            title = value;
        }
    }

    public virtual decimal Price
    {
        get { return price; }
        set
        {
            if (value<=0.0m)
            {
                throw new System.ArgumentException("Price not valid!");
            }
            price = value;
        }
    }

    public Book(string author, string title,decimal price)
    {
        Author = author;
        Title = title;
        Price = price;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"Type: {this.GetType().Name}");
        sb.AppendLine($"Title: {Title}");
        sb.AppendLine($"Author: {Author}");
        sb.AppendLine($"Price: {Price:f2}");


        var result = sb.ToString().TrimEnd();

        return result;
    }
}