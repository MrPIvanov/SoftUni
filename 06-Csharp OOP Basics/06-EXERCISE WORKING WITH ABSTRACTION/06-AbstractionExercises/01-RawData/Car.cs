using System.Collections.Generic;

public class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public Cargo Cargo { get; set; }
    public List<Tire> Tires { get; set; }


    public Car(string input)
    {
        var args = input.Split();

        Model = args[0];
        Engine = new Engine(int.Parse(args[1]), int.Parse(args[2]));
        Cargo = new Cargo(int.Parse(args[3]), args[4]);
        Tires = new List<Tire>();
        Tires.Add(new Tire(double.Parse(args[5]), int.Parse(args[6])));
        Tires.Add(new Tire(double.Parse(args[7]), int.Parse(args[8])));
        Tires.Add(new Tire(double.Parse(args[9]), int.Parse(args[10])));
        Tires.Add(new Tire(double.Parse(args[11]), int.Parse(args[12])));

    }
}