public class Dispatcher : INameChangeable
{
    public event NameChangeEventHandler NameChangeEvent;

    private string name;

    public Dispatcher(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.OnNameChange(new NameChangeEventArgs(value));
            this.name = value;
        }
    }

    public void OnNameChange(NameChangeEventArgs args)
    {
        if (this.NameChangeEvent != null)
        {
            this.NameChangeEvent.Invoke(this, args);
        }
    }
}