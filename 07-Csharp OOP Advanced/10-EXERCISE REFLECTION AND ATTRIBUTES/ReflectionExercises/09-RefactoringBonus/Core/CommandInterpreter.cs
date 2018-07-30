using System;
using System.Linq;
using System.Reflection;

public class CommandInterpreter
{
    private IServiceProvider serviceProvider;

    public CommandInterpreter(IServiceProvider serviceProvider)
    {
        this.serviceProvider = serviceProvider;
    }

    public IExecutable InterpretCommand(string[] data, string commandName)
    {
        var assembly = Assembly.GetExecutingAssembly();
        var commandType = assembly.GetTypes().FirstOrDefault(c => c.Name == commandName + "Command");

        if (commandType == null)
        {
            throw new ArgumentException("Invalid Command");
        }
        if (!typeof(IExecutable).IsAssignableFrom(commandType))
        {
            throw new ArgumentException("Invalid CommandType");
        }


        var injectFields = commandType
            .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
            .Where(f => f.CustomAttributes.Any(ca => ca.AttributeType == typeof(InjectDependencyAttribute))).ToArray();

        var fieldsToInject = injectFields.Select(f => this.serviceProvider.GetService(f.FieldType)).ToArray();


        var instanceParams = new object[] { data }.Concat(fieldsToInject).ToArray();

        IExecutable instance = (IExecutable)Activator.CreateInstance(commandType, instanceParams);
        return instance;
    }

    public void ExecuteCommand(IExecutable instance)
    {
        instance.Execute();
    }
}