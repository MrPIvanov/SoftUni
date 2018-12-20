public class Bus : IVehicle
{
    public double FuelQuantity { get; set; }
    public double FuelConsumption { get; set; }
    public double TankCappacity { get; set; }

    public double PossibleTravelDistance => this.FuelQuantity / this.FuelConsumption;

    public Bus(double fuelQuantity, double fuelConsumption, double tankCappacity)
    {
        this.TankCappacity = tankCappacity;
        if (this.TankCappacity >= fuelQuantity)
        {
            this.FuelQuantity = fuelQuantity;
        }
        else
        {
            this.FuelQuantity = 0.0d;
        }
        this.FuelConsumption = fuelConsumption + 1.4d;
    }

    public void Refil(double amountOfFuel)
    {
        if (amountOfFuel <= 0)
        {
            System.Console.WriteLine("Fuel must be a positive number");
        }
        else
        {
            if (this.FuelQuantity + amountOfFuel > this.TankCappacity)
            {
                System.Console.WriteLine($"Cannot fit {amountOfFuel} fuel in the tank");
            }
            else
            {
                this.FuelQuantity += amountOfFuel;
            }
        }
    }

    public void Drive(double distance)
    {
        if (distance > this.PossibleTravelDistance)
        {
            System.Console.WriteLine($"Bus needs refueling");
        }
        else
        {
            System.Console.WriteLine($"Bus travelled {distance} km");
            this.FuelQuantity -= distance * this.FuelConsumption;
        }
    }

    public void DriveEmpty(double distance)
    {
        if (distance > this.FuelQuantity / (this.FuelConsumption - 1.4d))
        {
            System.Console.WriteLine($"Bus needs refueling");
        }
        else
        {
            System.Console.WriteLine($"Bus travelled {distance} km");
            this.FuelQuantity -= distance * (this.FuelConsumption - 1.4d);
        }
    }
}