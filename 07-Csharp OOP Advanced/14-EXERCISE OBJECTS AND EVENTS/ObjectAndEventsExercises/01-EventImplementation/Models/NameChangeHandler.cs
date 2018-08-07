using System;

public class NameChangeHandler : INameChangeHandler
{
    public void OnDispatcherNameChange(object sender, NameChangeEventArgs args)
    {
        Console.WriteLine($"Dispatcher's name changed to {args.Name}.");
    }
}