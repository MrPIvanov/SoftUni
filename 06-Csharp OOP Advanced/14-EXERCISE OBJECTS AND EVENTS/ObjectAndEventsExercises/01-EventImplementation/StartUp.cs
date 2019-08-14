using System;

public class StartUp
{
    static void Main()
    {
        INameChangeable dispatcher = new Dispatcher("Ivan");
        INameChangeHandler handler = new NameChangeHandler();

        dispatcher.NameChangeEvent += handler.OnDispatcherNameChange;

        string name;
        while ((name = Console.ReadLine()) != "End")
        {
            dispatcher.Name = name;
        }
    }
}