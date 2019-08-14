namespace _03BarracksFactory
{
    using Contracts;
    using Core;
    using Core.Factories;
    using Data;
    using System;
    using Microsoft.Extensions.DependencyInjection;

    class AppEntryPoint
    {
        static void Main(string[] args)
        {
            IServiceProvider serviceProvider = ConfigureServises();

            ICommandInterpreter commandInterpreter = new CommandInterpreter(serviceProvider);
            IRunnable engine = new Engine(commandInterpreter);
            engine.Run();
        }

        private static IServiceProvider ConfigureServises()
        {
            IServiceCollection servises = new ServiceCollection();

            servises.AddTransient<IUnitFactory, UnitFactory>();
            servises.AddSingleton<IRepository, UnitRepository>();

            IServiceProvider serviceProvider = servises.BuildServiceProvider();
            return serviceProvider;
        }
    }
}
