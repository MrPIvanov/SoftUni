public class ConsoleAppender : IAppender
{
    public ILayout Layout { get;private set; }
    public ErrorLevels Level { get;private set; }
    public int MessagesLog { get; private set; }

    public ConsoleAppender(ILayout layout, ErrorLevels level)
    {
        this.Layout = layout;
        this.Level = level;
        this.MessagesLog = 0;
    }

    public void Append(IError error)
    {
        if (this.Level<=error.Level)
        {
            var formatedError = Layout.FormatError(error);
            System.Console.WriteLine(formatedError);
            this.MessagesLog++;
        }
    }

    public override string ToString()
    {
        return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.Level}, Messages appended: {this.MessagesLog}";
    }
}