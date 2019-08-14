using SoftUniRestaurant.Models.Drinks.Contracts;
using SoftUniRestaurant.Models.Foods.Contracts;
using SoftUniRestaurant.Models.Tables.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam.Models.Tables
{
    public abstract class Table : ITable
    {
        private int tableNumber;

        private int capacity;

        private int numberOfPeople;

        private decimal pricePerPerson;

        private bool isReserved;

        private List<IFood> foodOrders;

        private List<IDrink> drinkOrders;

        public Table(int tableNumber, int capacity, decimal pricePerPerson)
        {
            this.TableNumber = tableNumber;

            this.Capacity = capacity;

            this.PricePerPerson = pricePerPerson;

            this.foodOrders = new List<IFood>();

            this.drinkOrders = new List<IDrink>();
        }

        public decimal Price => this.NumberOfPeople * this.PricePerPerson;

        public IReadOnlyCollection<IFood> FoodOrders => this.foodOrders.AsReadOnly();

        public IReadOnlyCollection<IDrink> DrinkOrders => this.drinkOrders.AsReadOnly();

        public bool IsReserved
        {
            get { return isReserved; }
            set { isReserved = value; }
        }


        public decimal PricePerPerson
        {
            get { return pricePerPerson; }
            private set { pricePerPerson = value; }
        }


        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Cannot place zero or less people!");
                }

                numberOfPeople = value;
            }
        }


        public int Capacity
        {
            get { return capacity; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Capacity has to be greater than 0");
                }

                capacity = value;
            }
        }


        public int TableNumber
        {
            get { return tableNumber; }
            private set { tableNumber = value; }
        }


        public void Reserve(int numberOfPeople)
        {
            this.IsReserved = true;
            this.NumberOfPeople = numberOfPeople;
        }

        public void OrderFood(IFood food)
        {
            this.foodOrders.Add(food);
        }
        
        public void OrderDrink(IDrink drink)
        {
            this.drinkOrders.Add(drink);
        }

        public decimal GetBill()
        {
            var resultFoods = this.FoodOrders.Sum(f => f.Price);

            var resultDrinks = this.DrinkOrders.Sum(d => d.Price);

            var priceForPersons = this.PricePerPerson * this.NumberOfPeople;

            return resultDrinks + resultFoods + priceForPersons;
        }

        public void Clear()
        {
            this.IsReserved = false;
            this.foodOrders = new List<IFood>();
            this.drinkOrders = new List<IDrink>();
            this.numberOfPeople = 0;
        }

        public string GetFreeTableInfo()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Table: {this.TableNumber}");
            sb.AppendLine($"Type: {this.GetType().Name}");
            sb.AppendLine($"Capacity: {this.Capacity}");
            sb.AppendLine($"Price per Person: {this.PricePerPerson:f2}");

            var result = sb.ToString().TrimEnd();
            return result;
        }

        public string GetOccupiedTableInfo()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Table: {this.TableNumber}");
            sb.AppendLine($"Type: {this.GetType().Name}");
            sb.AppendLine($"Number of people: {this.NumberOfPeople}");

            if (this.FoodOrders.Count <= 0)
            {
                sb.AppendLine($"Food orders: None");
            }
            else
            {
                sb.AppendLine($"Food orders: {this.FoodOrders.Count}");

                foreach (var food in this.FoodOrders)
                {
                    sb.AppendLine(food.ToString());
                }
            }

            if (this.DrinkOrders.Count <= 0)
            {
                sb.AppendLine($"Drink orders: None");
            }
            else
            {
                sb.AppendLine($"Drink orders: {this.DrinkOrders.Count}");

                foreach (var drink in this.DrinkOrders)
                {
                    sb.AppendLine(drink.ToString());
                }
            }

            var result = sb.ToString().TrimEnd();
            return result;
        }
    }
}
