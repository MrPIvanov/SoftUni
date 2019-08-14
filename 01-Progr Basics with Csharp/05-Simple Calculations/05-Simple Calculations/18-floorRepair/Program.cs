using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_floorRepair
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Pls entrer the side of the ground: ");
            double sideSquare = double.Parse(Console.ReadLine());
            //Console.Write("Pls entrer the one side of the tile: ");
            double sideA = double.Parse(Console.ReadLine());
           // Console.Write("Pls entrer the second side of the tile: ");
            double sideB = double.Parse(Console.ReadLine());
           // Console.Write("Pls entrer the one side of the bench: ");
            double sideABench = double.Parse(Console.ReadLine());
           // Console.Write("Pls entrer the second side of the bench: ");
            double sideBBench = double.Parse(Console.ReadLine());

            double areaAll = sideSquare * sideSquare;
            double areaBench = sideABench * sideBBench;
            double areaTile = sideA * sideB;

            double areaToDo = areaAll - areaBench;
            double numberOfTiles = areaToDo / areaTile;
            double numberOfTime = numberOfTiles * 0.2;
            Console.WriteLine(Math.Round(numberOfTiles, 2).ToString("0.00"));               //When you need to show the     !!!!!!
            Console.WriteLine(Math.Round(numberOfTime, 2).ToString("0.00"));                //zeros after . dot (point)     !!!!!!
            Console.ReadLine();                                                        // OR Console.Write($"{a:f2}");      !!!!!!
                                                                    //where "a" is our double variable after Math.Round(a,2);!!!!!




        }
    }
}
