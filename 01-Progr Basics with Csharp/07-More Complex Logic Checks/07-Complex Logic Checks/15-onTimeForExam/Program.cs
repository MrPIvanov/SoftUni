using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_onTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minExam = int.Parse(Console.ReadLine());
            int hourArive = int.Parse(Console.ReadLine());
            int minArive = int.Parse(Console.ReadLine());

            int minDifrence = (hourExam - hourArive) * 60 + (minExam-minArive);

            if (minDifrence<0)
            {
                Console.WriteLine("Late");
                int hourDifrence = Math.Abs(minDifrence / 60);
                int finalMin = Math.Abs(minDifrence % 60);
                
                if (hourDifrence!=0)
                {
                    Console.WriteLine($"{hourDifrence}:{finalMin.ToString("00")} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{finalMin} minutes after the start");
                }
            }
            else if (minDifrence>=0&&minDifrence<=30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{minDifrence} minutes before the start");
                
                
            }

            else
            {
                Console.WriteLine("Early");
                int hourDifrence = minDifrence / 60;
                int finalMin = minDifrence % 60;
                if (hourDifrence != 0)
                {
                    Console.WriteLine($"{hourDifrence}:{finalMin.ToString("00")} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{finalMin.ToString("00")} minutes before the start");
                }




            }


        }
    }
}

