using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            double cakeWeight = double.Parse(Console.ReadLine());
            double cakeHeight = double.Parse(Console.ReadLine());

            double allPeaceOfCakes = cakeHeight * cakeWeight;

            double peaceOfCakesTaken = 0;



            do
            {

                string vhod = Console.ReadLine();

                if (vhod=="STOP")
                {
                    break;
                }

                else
                {
                    int novVhod = int.Parse(vhod);
                    peaceOfCakesTaken += novVhod;
                }

                

            } while (peaceOfCakesTaken <= allPeaceOfCakes);



            if (peaceOfCakesTaken>=allPeaceOfCakes)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(peaceOfCakesTaken-allPeaceOfCakes)} pieces more.");

            }
            else
            {
                Console.WriteLine($"{allPeaceOfCakes-peaceOfCakesTaken} pieces are left.");
            }


        }
    }
}
