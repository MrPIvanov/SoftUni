using System.Text;

public class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public int Weight { get; set; }
    public string Color { get; set; }



    public Car(string[] carInput, Engine engine)
    {
        Model = carInput[0];
        Engine = engine;
        Color = "n/a";

        if (carInput.Length == 3)
        {
            try
            {
                Weight = int.Parse(carInput[2]);
                Color = "n/a";
            }
            catch (System.Exception)
            {

                Color = carInput[2];
            }
        }
        else if (carInput.Length == 4)
        {
            Weight = int.Parse(carInput[2]);
            Color = carInput[3];
        }


    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{Model}:");
        sb.AppendLine($"  {Engine.Model}:");
        sb.AppendLine($"    Power: {Engine.Power}");
        sb.AppendLine($"    Displacement: {((Engine.Displacement==0) ? "n/a" : Engine.Displacement.ToString())}");
        sb.AppendLine($"    Efficiency: {Engine.Efficiency}");
        sb.AppendLine($"  Weight: {((Weight == 0) ? "n/a" : Weight.ToString())}");
        sb.AppendLine($"  Color: {Color}");

        var result = sb.ToString().Trim();
        return result;



    }


}