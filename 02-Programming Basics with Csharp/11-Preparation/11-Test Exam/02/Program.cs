using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {

            double tripPrice = double.Parse(Console.ReadLine());
            double puzleCount = double.Parse(Console.ReadLine());
            double talkingDollsCount = double.Parse(Console.ReadLine());
            double bearsCount = double.Parse(Console.ReadLine());
            double minionsCount = double.Parse(Console.ReadLine());
            double trucksCount = double.Parse(Console.ReadLine());


            double puzleMoney = puzleCount * 2.6;
            double dollsMoney = talkingDollsCount * 3;
            double bearsMoney = bearsCount * 4.1;
            double minionsMoney = minionsCount * 8.2;
            double trucksMoney = trucksCount * 2;

            double allMoney = puzleMoney + dollsMoney + bearsMoney + minionsMoney + trucksMoney;

            if (puzleCount+talkingDollsCount+bearsCount+minionsCount+trucksCount>=50)
            {
                allMoney *=0.75;
            }

            allMoney *= 0.9;

            if (allMoney>=tripPrice)
            {
                Console.WriteLine($"Yes! {(allMoney-tripPrice):f2} lv left.");
            }

            else
            {
                Console.WriteLine($"Not enough money! {(tripPrice-allMoney):f2} lv needed.");
            }

        }
    }
}
