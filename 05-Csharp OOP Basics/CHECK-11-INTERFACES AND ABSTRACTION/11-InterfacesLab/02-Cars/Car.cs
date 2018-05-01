using System;
using System.Text;

public class Car : ICar
{
    private string model;
    private string color;
   
    public string Model
    {
        get { return model; }
        private set { model = value; }
    }

    public string Color
    {
        get { return color; }
        private set { color = value; }
    }

    public Car(string model, string color)
    {
        Model = model;
        Color = color;
    }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }
    public override string ToString()
    {
        return $"{Color} {Model}{Environment.NewLine}{Start()}{Environment.NewLine}{Stop()}";
    }
}