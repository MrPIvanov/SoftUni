using Microsoft.Extensions.DependencyInjection;
using System;

public class StartUp
{
    static void Main()
    {
        IServiceProvider serviceProvider = ConfigureServiceProvider();

        var commandInterpeter = new CommandInterpreter(serviceProvider);

        var engine = new Engine(commandInterpeter);
        engine.Run();
    }

    private static IServiceProvider ConfigureServiceProvider()
    {
        IServiceCollection collection = new ServiceCollection();

        collection.AddSingleton<IRepository, Repository>();

        collection.AddTransient<IGemFactory, GemFactory>();

        collection.AddTransient<IWeaponFactory, WeaponFactory>();

        var serviceProvider = collection.BuildServiceProvider();

        return serviceProvider;
    }
}