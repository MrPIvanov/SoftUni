using System;

public class Tesla : Car, IElectricCar
{
    private int battery;

    public int Battery
    {
        get { return battery; }
        private set { battery = value; }
    }

    public Tesla(string model, string color, int battery)
        :base(model, color)
    {
        Battery = battery;
    }

    public override string ToString()
    {
        return $"{Color} {Model} with {Battery} Batteries{Environment.NewLine}{Start()}{Environment.NewLine}{Stop()}";
    }
}