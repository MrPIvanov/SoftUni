public class Error : IError
{
    public ErrorLevels Level { get; private set; }
    public string DateTime { get; private set; }
    public string Message { get; private set; }

    public Error(ErrorLevels level, string dateTime, string message)
    {
        this.Level = level;
        this.DateTime = dateTime;
        this.Message = message;
    }
}