namespace _06_TrafficLight
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            var numberOfCars = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var queue = new Queue<string>();
            var counter = 0;


            while (input!="end")
            {
                if (input=="green")
                {
                    var carsToPass = Math.Min(numberOfCars, queue.Count);
                    for (int i = 0; i < carsToPass; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        counter++;

                    }
                }
                else
                {
                    queue.Enqueue(input);
                }




                input = Console.ReadLine();
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}

