using System;
using System.Linq;

public class Engine : IRunable
{
    private CommandInterpreter commandInterpreter;

    public Engine(CommandInterpreter commandInterpreter)
    {
        this.commandInterpreter = commandInterpreter;
    }

    public void Run()
    {
        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            var tokens = input.Split(';');
            var commandName = tokens[0];
            var data = tokens.Skip(1).ToArray();

            var commandIntance =this.commandInterpreter.InterpretCommand(data, commandName);
            this.commandInterpreter.ExecuteCommand(commandIntance);
        }
    }
}