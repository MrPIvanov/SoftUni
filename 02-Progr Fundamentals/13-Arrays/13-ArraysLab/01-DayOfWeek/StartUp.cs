namespace _01_DayOfWeek
{
    using System;

    class StartUp
    {
        static void Main()
        {
            string[] days = new string[7];

            days[0]= "Monday";
            days[1] = "Tuesday";
            days[2] = "Wednesday";
            days[3] = "Thursday";
            days[4] = "Friday";
            days[5] = "Saturday";
            days[6] = "Sunday";

            int day = int.Parse(Console.ReadLine());

            if (day<=0||day>7)
            {
                Console.WriteLine("Invalid Day!");
            }

            else
            {
                Console.WriteLine($"{days[day-1]}");
            }


        }
    }
}