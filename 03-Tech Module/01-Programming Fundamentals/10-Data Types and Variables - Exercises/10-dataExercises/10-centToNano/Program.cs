using System;

namespace _10_centToNano
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int min = hours * 60;
            long sec = (long)min * 60;
            long milisec =sec*1000;
            long microsec = milisec*1000;
            decimal nanosec = (decimal)microsec*1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {min} minutes = {sec} seconds =" +
                              $" {milisec} milliseconds = {microsec} microseconds = {nanosec} nanoseconds");
        }
    }
}