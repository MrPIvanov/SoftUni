using System;

public class Engine
{
    public string Model { get; set; }
    public int Power { get; set; }
    public int Displacement { get; set; }
    public string Efficiency { get; set; }

    public Engine(string engineInput)
    {
        var args = engineInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Model = args[0];
        Power = int.Parse(args[1]);
        Efficiency = "n/a";

        if (args.Length==3)
        {
            try
            {
                Displacement = int.Parse(args[2]);
                Efficiency = "n/a";

            }
            catch (System.Exception)
            {

                Efficiency = args[2];
            }
        }
        else if (args.Length==4)
        {
            Displacement = int.Parse(args[2]);
            Efficiency = args[3];
        }

    }

}