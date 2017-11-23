using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_calCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCalories = 0;
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string curIngredient = Console.ReadLine().ToLower();

                if (curIngredient=="cheese")
                {
                    totalCalories +=500;
                }
                else if (curIngredient=="tomato sauce")
                {
                    totalCalories +=150;
                }
                else if (curIngredient == "salami")
                {
                    totalCalories += 600;
                }
                else if (curIngredient == "pepper")
                {
                    totalCalories += 50;
                }
            }


            Console.WriteLine($"Total calories: {totalCalories}");


        }
    }
}
