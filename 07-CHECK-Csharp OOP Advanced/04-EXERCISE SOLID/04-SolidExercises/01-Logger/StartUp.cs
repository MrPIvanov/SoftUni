using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        var numberOfAppender = int.Parse(Console.ReadLine());
        ICollection<IAppender> appenders =  InitializeAppenders(numberOfAppender);

        ILogger logger = new Logger(appenders);
        Engine engine = new Engine(logger);
        engine.Run();
    }

    private static ICollection<IAppender> InitializeAppenders(int numberOfAppender)
    {
        var collection = new List<IAppender>();
        var appenderFactory = new AppenderFactory();

        for (int i = 0; i < numberOfAppender; i++)
        {
            var appenderInfo = Console.ReadLine();

            var appender = appenderFactory.CreateAppender(appenderInfo);

            collection.Add(appender);
        }
        return collection;
    }
}