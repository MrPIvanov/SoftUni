using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_pointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());


            if ((x < 0 || x > 3 * side) || (y < 0 || y > 4 * side))
            {
                Console.WriteLine("outside");
            }
            else if (((x>=0&&x<side)&&(y>side))||((x>2*side)&&(y>side)))
            {
                Console.WriteLine("outside");

            }
            else if ((x>0&&x<3*side)&&(y<side&&y>0))
            {
                Console.WriteLine("inside");
            }
            else if ((x>side&&x<2*side)&&(y>0&&y<4*side))
            {
                Console.WriteLine("inside");

            }
            else
            {
                Console.WriteLine("border");
            }


        }
    }
}
