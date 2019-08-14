namespace SoftUniRestaurant.Core
{
    using Exam.Models.Drinks;
    using Exam.Models.Foods;
    using Exam.Models.Tables;
    using SoftUniRestaurant.Models.Drinks.Contracts;
    using SoftUniRestaurant.Models.Foods.Contracts;
    using SoftUniRestaurant.Models.Tables.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class RestaurantController
    {
        private List<IFood> menu;

        private List<IDrink> drinks;

        private List<ITable> tables;

        private decimal totalIncome;

        public RestaurantController()
        {
            this.menu = new List<IFood>();

            this.drinks = new List<IDrink>();

            this.tables = new List<ITable>();
        }

        public string AddFood(string type, string name, decimal price)
        {
            IFood food = null;

            switch (type)
            {
                case "Dessert":
                    food = new Dessert(name, price);
                    break;

                case "Salad":
                    food = new Salad(name, price);
                    break;

                case "MainCourse":
                    food = new MainCourse(name, price);
                    break;

                case "Soup":
                    food = new Soup(name, price);
                    break;

                default:
                    break;
            }



            this.menu.Add(food);
            var result = $"Added {food.Name} ({food.GetType().Name}) with price {food.Price:f2} to the pool";
            return result;
        }

        public string AddDrink(string type, string name, int servingSize, string brand)
        {
            IDrink drink = null;

            switch (type)
            {
                case "Alcohol":
                    drink = new Alcohol(name, servingSize, brand);
                    break;

                case "FuzzyDrink":
                    drink = new FuzzyDrink(name, servingSize, brand);
                    break;

                case "Juice":
                    drink = new Juice(name, servingSize, brand);
                    break;

                case "Water":
                    drink = new Water(name, servingSize, brand);
                    break;

                default:
                    break;
            }



            this.drinks.Add(drink);
            var result = $"Added {drink.Name} ({drink.Brand}) to the drink pool";
            return result;
        }

        public string AddTable(string type, int tableNumber, int capacity)
        {
            ITable table = null;

            switch (type)
            {
                case "Inside":
                    table = new InsideTable(tableNumber, capacity);
                    break;

                case "Outside":
                    table = new OutsideTable(tableNumber, capacity);
                    break;

                default:
                    break;
            }



            this.tables.Add(table);
            var result = $"Added table number {table.TableNumber} in the restaurant";
            return result;
        }

        public string ReserveTable(int numberOfPeople)
        {
            var table = this.tables.Where(t => t.IsReserved == false).Where(t => t.Capacity >= numberOfPeople).FirstOrDefault();

            var result = "";
            if (table == null)
            {
                result = $"No available table for {numberOfPeople} people";
            }
            else
            {
                result = $"Table {table.TableNumber} has been reserved for {numberOfPeople} people";
                table.IsReserved = true;
                table.NumberOfPeople = numberOfPeople;
            }

            return result;
        }

        public string OrderFood(int tableNumber, string foodName)
        {
            var result = "";

            var table = this.tables.FirstOrDefault(t => t.TableNumber == tableNumber);
            var food = this.menu.FirstOrDefault(f => f.Name == foodName);

            if (table == null)
            {
                result = $"Could not find table with {tableNumber}";
            }

            else if (food == null)
            {
                result = $"No {foodName} in the menu";
            }
            else
            {
                table.OrderFood(food);

                result = $"Table {tableNumber} ordered {foodName}";
            }

            return result;
        }

        public string OrderDrink(int tableNumber, string drinkName, string drinkBrand)
        {
            var result = "";

            var table = this.tables.FirstOrDefault(t => t.TableNumber == tableNumber);
            var drink = this.drinks.Where(d => d.Name == drinkName).FirstOrDefault(d => d.Brand == drinkBrand);

            if (table == null)
            {
                result = $"Could not find table with {tableNumber}";
            }

            else if (drink == null)
            {
                result = $"There is no {drinkName} {drinkBrand} available";
            }

            else
            {
                result = $"Table {tableNumber} ordered {drinkName} {drinkBrand}";

                table.OrderDrink(drink);
            }

            return result;
        }

        public string LeaveTable(int tableNumber)
        {
            var table = this.tables.FirstOrDefault(t => t.TableNumber == tableNumber);

            var bill = table.GetBill();

            this.totalIncome += bill;

            var result = $"Table: {tableNumber}{Environment.NewLine}Bill: {bill:f2}";

            table.Clear();

            return result;
        }

        public string GetFreeTablesInfo()
        {
            var sb = new StringBuilder();

            var tables = this.tables.Where(t => t.IsReserved == false).ToArray();

            foreach (var table in tables)
            {
                sb.AppendLine(table.GetFreeTableInfo());
            }

            var result = sb.ToString().TrimEnd();

            return result;
        }

        public string GetOccupiedTablesInfo()
        {
            var sb = new StringBuilder();

            var tables = this.tables.Where(t => t.IsReserved == true).ToArray();

            foreach (var table in tables)
            {
                sb.AppendLine(table.GetOccupiedTableInfo());
            }

            var result = sb.ToString().TrimEnd();

            return result;
        }

        public string GetSummary()
        {
            var income = 0.0m;

            income = this.totalIncome;

            var result = $"Total income: {income:f2}lv";

            return result;
        }
    }
}
