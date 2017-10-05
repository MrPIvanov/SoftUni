using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_foreign
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine().ToLower();

            switch (country)
            {
                case "usa":
                    Console.WriteLine($"English");
                    break;
                case "england":
                    Console.WriteLine($"English");
                    break;
                case "spain":
                    Console.WriteLine($"Spanish");
                    break;
                case "argentina":
                    Console.WriteLine($"Spanish");
                    break;
                case "mexico":
                    Console.WriteLine($"Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }



        }
    }
}
