namespace _06_TruckTour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var numberOfPumps = int.Parse(Console.ReadLine());
            var distanceQue = new Queue<long>();
            var petrolQue = new Queue<long>();

            for (int i = 1; i <= numberOfPumps; i++)
            {
                var pump = Console.ReadLine().Split();

                distanceQue.Enqueue(long.Parse(pump[1]));
                petrolQue.Enqueue(long.Parse(pump[0]));
            }

            long currentFuelTotal = 0;
            bool reachableNextPump = true;
            for (int i = 0; i < numberOfPumps; i++)
            {

                for (int y = 0; y < numberOfPumps; y++)
                {
                    var currentPetrol = petrolQue.Dequeue();
                    var neededDistance = distanceQue.Dequeue();
                    
                    currentFuelTotal += currentPetrol;
                    currentFuelTotal -= neededDistance;

                    if (currentFuelTotal < 0)
                    {
                        reachableNextPump = false;

                    }
                    petrolQue.Enqueue(currentPetrol);
                    distanceQue.Enqueue(neededDistance);
                }

                if (reachableNextPump)
                {
                    Console.WriteLine(i);
                    break;
                }
                currentFuelTotal = 0;
                var moveQue = petrolQue.Dequeue();
                petrolQue.Enqueue(moveQue);
                moveQue = distanceQue.Dequeue();
                distanceQue.Enqueue(moveQue);
                reachableNextPump = true;
            }

        }
    }
}
