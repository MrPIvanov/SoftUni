using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_vaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal moneySpent = 0;
            decimal curentMoney = money;


            for (int i = 0; i < int.MaxValue; i++)
            {
                string input = Console.ReadLine();

                if (input=="OutFall 4"||input== "CS: OG" || input=="Zplinter Zell"||input=="Honored 2"||input=="RoverWatch"||input== "RoverWatch Origins Edition"||input=="Game Time")
                {
                    decimal curentPrice = 0;

                    switch (input)
                    {
                        case "OutFall 4":
                            curentPrice =39.99m;
                            break;
                        case "CS: OG":
                            curentPrice = 15.99m;
                            break;
                        case "Zplinter Zell":
                            curentPrice = 19.99m;
                            break;
                        case "Honored 2":
                            curentPrice = 59.99m;
                            break;
                        case "RoverWatch":
                            curentPrice = 29.99m;
                            break;
                        case "RoverWatch Origins Edition":
                            curentPrice = 39.99m;
                            break;
                    }

                    if  (input == "Game Time")
                    {
                        Console.WriteLine($"Total spent: ${(moneySpent):f2}. Remaining: ${(money - moneySpent):f2}");
                        break;
                    }

                    else if (curentMoney-curentPrice==0)
                    {
                        Console.WriteLine($"Bought {input}");
                        Console.WriteLine("Out of money!");
                        break;
                    }

                    else if (curentMoney-curentPrice<0)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else if (curentMoney-curentPrice>0)
                    {
                        Console.WriteLine($"Bought {input}");
                        moneySpent +=curentPrice;
                        curentMoney -= curentPrice;
                    }

                    
                }

                else 
                {
                    Console.WriteLine("Not Found");
                }

            }




        }
    }
}
