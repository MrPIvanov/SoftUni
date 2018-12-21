using System;

public class AppenderFactory
{
    public IAppender CreateAppender(string appenderInfo)
    {
        var args = appenderInfo.Split();
        var type = args[0];

        var layoutString = args[1];
        var layoutFactory = new LayoutFactory();
        var layout = layoutFactory.CreateLayout(layoutString);

        var level = ErrorLevels.INFO;
        if (args.Length == 3)
        {
            level = (ErrorLevels)Enum.Parse(typeof(ErrorLevels), args[2]);
        }

        IAppender appender = null;
        switch (type)
        {
            case "ConsoleAppender":
                appender = new ConsoleAppender(layout,level);
                break;
            default:
                throw new ArgumentException("Invalid Appender Type!");
        }
        return appender;
    }
}