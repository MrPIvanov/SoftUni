using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main()
    {
        var greenLightDuration = int.Parse(Console.ReadLine());
        var freeWindowDuration = int.Parse(Console.ReadLine());

        var numberOfCarsPassed = 0;
        var crashHappen = false;
        var cars = new Queue<string>();

        var input = "";
        while ((input = Console.ReadLine()) != "END")
        {
            if (input == "green")
            {
                var currentTimeLeft = greenLightDuration;

                while (currentTimeLeft > 0 && cars.Count > 0)
                {
                    var currentCarLength = cars.Peek().Length;

                    if (currentCarLength < currentTimeLeft)
                    {
                        numberOfCarsPassed++;
                        cars.Dequeue();
                        currentTimeLeft -= currentCarLength;
                    }
                    else if(currentCarLength <= currentTimeLeft + freeWindowDuration)
                    {
                        numberOfCarsPassed++;
                        cars.Dequeue();
                        currentTimeLeft -= currentCarLength;
                    }
                    else
                    {
                        //crash
                        var indexOfElementOfCrash = currentTimeLeft + freeWindowDuration;

                        crashHappen = true;
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{cars.Peek()} was hit at {cars.Peek()[indexOfElementOfCrash]}.");

                        break;

                    }
                }
                
            }
            else
            {
                cars.Enqueue(input);
            }

            if (crashHappen)
            {
                break;
            }
        }

        if (!crashHappen)
        {
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{numberOfCarsPassed} total cars passed the crossroads.");
        }
    }
}