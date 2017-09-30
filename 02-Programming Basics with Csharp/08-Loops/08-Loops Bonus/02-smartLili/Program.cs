using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_smartLili
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            double targetMoney = double.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double presents = 0;
            double allMoney = 0;
            double moneyTimer = 1;

            for (int i = 1; i <=age; i++)
            {
                if (i%2!=0)
                {
                    presents++;
                }
                else
                {
                    allMoney = allMoney + (moneyTimer*10);
                    moneyTimer++;
                    allMoney--;
                }


            }

            double allMoneyPresents = presents * presentPrice;
            double money = allMoney + allMoneyPresents;

            if (targetMoney>money)
            {
                Console.WriteLine($"No! {(targetMoney-money):f2}");
            }

            else
            {
                Console.WriteLine($"Yes! {(money-targetMoney):f2}");
            }



        }
    }
}
