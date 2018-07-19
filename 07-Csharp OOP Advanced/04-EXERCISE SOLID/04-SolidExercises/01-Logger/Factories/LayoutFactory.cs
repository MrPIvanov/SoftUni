using System;

public class LayoutFactory
{
    public ILayout CreateLayout(string layoutString)
    {
        ILayout layout = null;
        switch (layoutString)
        {
            case "SimpleLayout":
                layout = new SimpleLayout();
                break;
            default:
                throw new ArgumentException("Invalid Layout Type!");
        }
        return layout;
    }
}