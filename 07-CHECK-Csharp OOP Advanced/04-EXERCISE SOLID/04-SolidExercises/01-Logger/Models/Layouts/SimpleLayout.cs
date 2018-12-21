public class SimpleLayout : ILayout
{
    public string Format { get; private set; }

    public SimpleLayout()
    {
        this.Format = "{0} - {1} - {2}";
    }

    public string FormatError(IError error)
    {
        var result = string.Format(this.Format, error.DateTime, error.Level, error.Message);
        return result;
    }
}