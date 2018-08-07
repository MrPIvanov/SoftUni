public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);

public interface INameChangeable : INameable
{
    event NameChangeEventHandler NameChangeEvent;

    void OnNameChange(NameChangeEventArgs args);
}