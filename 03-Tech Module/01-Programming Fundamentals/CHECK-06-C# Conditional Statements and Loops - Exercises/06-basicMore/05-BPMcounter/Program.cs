using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BPMcounter
{
    class Program
    {
        static void Main(string[] args)
        {
            double beatsPerMin = double.Parse(Console.ReadLine());
            double numberOfBeats = double.Parse(Console.ReadLine());
            double bars = Math.Round(numberOfBeats / 4,1);


            double numberOfSec = Math.Floor((numberOfBeats / beatsPerMin) * 60);

            int finalMin = 0;
            double finalSec = numberOfSec;

            for (int i = 0; i < int.MaxValue; i++)
            {
                if (numberOfSec>=60)
                {
                    finalMin++;
                    finalSec -= 60;
                    numberOfSec -= 60;
                }
                else
                {
                    break;
                }
            }


            Console.WriteLine($"{bars} bars - {finalMin}m {finalSec}s");
        }
    }
}
