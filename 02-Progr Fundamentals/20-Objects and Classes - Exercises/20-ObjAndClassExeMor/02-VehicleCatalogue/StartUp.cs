using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_VehicleCatalogue
{
    public class StartUp
    {
        public static void Main()
        {
            var allMachines = new List<Machine>();
            string input;
            while ((input = Console.ReadLine()) !="End")
            {
                allMachines.Add(new Machine(input));

            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                Console.WriteLine(allMachines.Where(x => x.Model == input).First());
            }

            if (allMachines.Where(x => x.Type == "car").Select(x => x.Horsepower).Sum()==0.0)
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of:" +
                $" {allMachines.Where(x => x.Type == "car").Select(x => x.Horsepower).Average():F2}.");
            }

            if (allMachines.Where(x => x.Type == "truck").Select(x => x.Horsepower).Sum()==0.0)
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of:" +
                $" {allMachines.Where(x => x.Type == "truck").Select(x => x.Horsepower).Average():F2}.");
            }
        }
    }

    public class Machine
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Horsepower { get; set; }

        public Machine(string input)
        {
            var inputArgs = input.Split();

            Type = inputArgs[0].ToLower();
            Model = inputArgs[1];
            Color = inputArgs[2];
            Horsepower = double.Parse(inputArgs[3]);

        }
        
        public override string ToString()
        {
            string result = "";

            var sb = new StringBuilder();
            var currentType = "";
            if (Type=="car")
            {
                currentType = "Car";
            }
            if (Type=="truck")
            {
                currentType = "Truck";
            }

            sb.AppendLine($"Type: {currentType}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {Horsepower}");

            result = sb.ToString().TrimEnd();
            return result;
        }
    } 
}