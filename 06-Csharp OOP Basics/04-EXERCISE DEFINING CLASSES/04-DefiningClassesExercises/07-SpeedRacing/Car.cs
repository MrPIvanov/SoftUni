public class Car
{
    public string Model { get; set; }
    public decimal FuelAmount { get; set; }
    public decimal FuelConsumptionPerKilometer { get; set; }
    public decimal DistanceTraveled { get; set; }

    public Car(string model, decimal fuelAmount, decimal fuelConsumptionPerKilometer)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        DistanceTraveled = 0.0m;
    }

    public Car Drive(Car car, decimal kilometersToDrive)
    {
        var posibleDistanceToTravel = FuelAmount / FuelConsumptionPerKilometer;
        if (kilometersToDrive>posibleDistanceToTravel)
        {
            System.Console.WriteLine("Insufficient fuel for the drive");

            return car;
        }
        else
        {
            var neededFuel = kilometersToDrive * FuelConsumptionPerKilometer;
            FuelAmount -= neededFuel;
            DistanceTraveled +=kilometersToDrive;

            return car;
        }


    }
}