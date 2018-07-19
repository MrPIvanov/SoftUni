using System;

public class Engine
{
    public ILogger Logger { get; set; }

    public Engine(ILogger logger)
    {
        this.Logger = logger;
    }

    public void Run()
    {
        string currentError;
        while ((currentError = Console.ReadLine()) != "END")
        {
            var errorArgs = currentError.Split('|');
            var level = (ErrorLevels)Enum.Parse(typeof(ErrorLevels), errorArgs[0]);
            var dateTime = errorArgs[1];
            var message = errorArgs[2];

            IError error = new Error(level, dateTime, message);
            this.Logger.Log(error);
        }

        Console.WriteLine("Logger Info");
        foreach (var appender in Logger.Appenders)
        {
            Console.WriteLine(appender);
        }
    }
}