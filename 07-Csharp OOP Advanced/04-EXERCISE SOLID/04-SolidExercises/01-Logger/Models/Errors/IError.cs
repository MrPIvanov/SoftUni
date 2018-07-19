public interface IError
{
    ErrorLevels Level { get; }
    string DateTime { get; }
    string Message { get; }
}