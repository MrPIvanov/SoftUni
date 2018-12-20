using SoftUniRestaurant.Models.Drinks.Contracts;
using SoftUniRestaurant.Models.Foods.Contracts;
using System.Collections.Generic;

namespace SoftUniRestaurant.Models.Tables.Contracts
{
    public interface ITable
    {
        int Capacity { get; }
        IReadOnlyCollection<IDrink> DrinkOrders { get; }
        IReadOnlyCollection<IFood> FoodOrders { get; }
        bool IsReserved { get; set; }
        int NumberOfPeople { get; set;  }
        decimal Price { get; }
        decimal PricePerPerson { get; }
        int TableNumber { get; }

        void Clear();
        decimal GetBill();
        string GetFreeTableInfo();
        string GetOccupiedTableInfo();
        void OrderDrink(IDrink drink);
        void OrderFood(IFood food);
        void Reserve(int numberOfPeople);
    }
}
