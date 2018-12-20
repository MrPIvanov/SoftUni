public class Car : IVehicle
{
    public double FuelQuantity { get; set; }
    public double FuelConsumption { get; set; }
    public double TankCappacity { get; set; }

    public double PossibleTravelDistance => this.FuelQuantity / this.FuelConsumption;

    public Car(double fuelQuantity, double fuelConsumption, double tankCappacity)
    {
        this.TankCappacity = tankCappacity;
        if (this.TankCappacity>=fuelQuantity)
        {
            this.FuelQuantity = fuelQuantity;
        }
        else
        {
            this.FuelQuantity = 0.0d;
        }
        this.FuelConsumption = fuelConsumption + 0.9d;
    }

    public void Refil(double amountOfFuel)
    {
        if (amountOfFuel<=0)
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