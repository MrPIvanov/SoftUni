using System.Collections.Generic;

public class Logger : ILogger
{
    public ICollection<IAppender> Appenders { get; set; }

    public Logger(ICollection<IAppender> appenders)
    {
        this.Appenders = appenders;   
    }

    public void Log(IError error)
    {
        foreach (var appender in this.Appenders)
        {
            appender.Append(error);
        }
    }
}