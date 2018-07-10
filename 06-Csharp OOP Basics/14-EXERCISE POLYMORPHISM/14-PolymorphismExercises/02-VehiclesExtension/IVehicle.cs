public interface IVehicle
{
    double FuelQuantity { get; }
    double FuelConsumption { get; }
    double PossibleTravelDistance { get; }
    double TankCappacity { get; }

    void Refil(double amountOfFuel);
    void Drive(double distance);
}