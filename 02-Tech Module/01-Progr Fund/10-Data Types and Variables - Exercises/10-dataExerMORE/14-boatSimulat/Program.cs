using System;

namespace _14_boatSimulat
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            int firstBoatLines = 0;
            int secondBoatLines = 0;

            for (int i = 1; i <= lines; i++)
            {
                string currentString = Console.ReadLine();

                if (currentString=="UPGRADE")
                {
                    firstBoat += (char)3;
                    secondBoat+=(char)3;
                }

                else
                {
                    if (i%2==1)
                    {
                        firstBoatLines += currentString.Length;
                        if (firstBoatLines>=50)
                        {
                            Console.WriteLine(firstBoat);
                            break;
                        }


                    }
                    else
                    {
                        secondBoatLines += currentString.Length;
                        if (secondBoatLines >= 50)
                        {
                            Console.WriteLine(secondBoat);
                            break;
                        }
                    }



                }


            }

            if (firstBoatLines<50&&secondBoatLines<50)
            {
                if (firstBoatLines > secondBoatLines)
                {
                    Console.WriteLine(firstBoat);
                }

                else
                {
                    Console.WriteLine(secondBoat);
                }

           
            }







        }
    }
}