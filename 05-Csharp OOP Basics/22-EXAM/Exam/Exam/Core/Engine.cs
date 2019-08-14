using SoftUniRestaurant.Core;
using System;
using System.Linq;

namespace Exam.Core
{
    public class Engine
    {
        private RestaurantController restaurantController;

        public Engine()
        {
            this.restaurantController = new RestaurantController();
        }

        public void Run()
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                try
                {
                    var result = ProcesCommand(input);
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }

            Console.WriteLine(this.restaurantController.GetSummary());
        }

        private string ProcesCommand(string input)
        {
            var result = "";

            var args = input.Split();

            var command = args[0];

            var tokens = args.Skip(1).ToArray();

            switch (command)
            {
                case "AddFood":
                    result = this.restaurantController.AddFood(tokens[0], tokens[1], decimal.Parse(tokens[2]));
                    break;

                case "AddDrink":
                    result = this.restaurantController.AddDrink(tokens[0], tokens[1], int.Parse(tokens[2]), tokens[3]);
                    break;

                case "AddTable":
                    result = this.restaurantController.AddTable(tokens[0], int.Parse(tokens[1]), int.Parse(tokens[2]));
                    break;

                case "ReserveTable":
                    result = this.restaurantController.ReserveTable(int.Parse(tokens[0]));
                    break;

                case "OrderFood":
                    result = this.restaurantController.OrderFood(int.Parse(tokens[0]), tokens[1]);
                    break;

                case "OrderDrink":
                    result = this.restaurantController.OrderDrink(int.Parse(tokens[0]), tokens[1], tokens[2]);
                    break;

                case "LeaveTable":
                    result = this.restaurantController.LeaveTable(int.Parse(tokens[0]));
                    break;

                case "GetFreeTablesInfo":
                    result = this.restaurantController.GetFreeTablesInfo();
                    break;

                case "GetOccupiedTablesInfo":
                    result = this.restaurantController.GetOccupiedTablesInfo();
                    break;



                default:
                    break;
            }

            return result;
        }
    }
}
