using System.Linq;

public class Phone : ICall, IBrowseWeb
{
    public string BrowseWeb(string site)
    {
        if (site.Where(x=>char.IsNumber(x)).ToList().Count()==0)
        {
            return $"Browsing: {site}!";
        }
        else
        {
            return $"Invalid URL!";
        }
    }

    public string Call(string number)
    {
        if (number.Where(x => char.IsNumber(x)).ToList().Count() == number.Length)
        {
            return $"Calling... {number}";
        }
        else
        {
            return $"Invalid number!";
        }
    }
}