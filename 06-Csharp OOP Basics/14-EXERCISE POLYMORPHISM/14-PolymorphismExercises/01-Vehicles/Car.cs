public class Car : IVehicle
{
    public double FuelQuantity { get; set; }
    public double FuelConsumption { get; set; }

    public double PossibleTravelDistance => this.FuelQuantity / this.FuelConsumption;

    public Car(double fuelQuantity, double fuelConsumption)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption + 0.9d;
    }

    public void Refil(double amountOfFuel)
    {
        this.FuelQuantity += amountOfFuel;
    }

    public void Drive(double distance)
    {
        if (distance>this.PossibleTravelDistance)
        {
            System.Console.WriteLine($"Car needs refueling");
        }
        else
        {
            System.Console.WriteLine($"Car travelled {distance} km");
            this.FuelQuantity -= distance * this.FuelConsumption;
        }
    }
}