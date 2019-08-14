public class Truck : IVehicle
{
    public double FuelQuantity { get; set; }
    public double FuelConsumption { get; set; }

    public double PossibleTravelDistance => this.FuelQuantity / this.FuelConsumption;

    public Truck(double fuelQuantity, double fuelConsumption)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption + 1.6d;
    }

    public void Refil(double amountOfFuel)
    {
        this.FuelQuantity += amountOfFuel * 0.95d;
    }

    public void Drive(double distance)
    {
        if (distance > this.PossibleTravelDistance)
        {
            System.Console.WriteLine($"Truck needs refueling");
        }
        else
        {
            System.Console.WriteLine($"Truck travelled {distance} km");
            this.FuelQuantity -= distance * this.FuelConsumption;
        }
    }
}