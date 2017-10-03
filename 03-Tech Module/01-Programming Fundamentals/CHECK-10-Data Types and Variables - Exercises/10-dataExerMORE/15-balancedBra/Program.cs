using System;

namespace _15_balancedBra
{
    class Program
    {
        static void Main(string[] args)
        {

            int lines = int.Parse(Console.ReadLine());
            int numberOfOpen = 0;
            int numberOfClose = 0;

            for (int i = 1; i <= lines; i++)
            {

                string currentString = Console.ReadLine();


                if (numberOfOpen<numberOfClose)
                {
                    break;
                }

                if (currentString.Contains("("))
                {
                    numberOfOpen++;
                }

                if (currentString.Contains(")"))
                {
                    numberOfClose++;
                }
            }

            if (numberOfOpen==numberOfClose)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }





        }
    }
}