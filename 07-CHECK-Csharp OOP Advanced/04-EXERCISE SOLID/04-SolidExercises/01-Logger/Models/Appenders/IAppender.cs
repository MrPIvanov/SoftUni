public interface IAppender
{
    int MessagesLog { get; }
    ILayout Layout { get; }
    ErrorLevels Level { get; }
    void Append(IError error);
}