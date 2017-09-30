using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_enterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < int.MaxValue; i++)
            {
                string number = Console.ReadLine();
                int intNumber = 0;

                    int.TryParse(number, out intNumber);

                    if (intNumber==0)
                    {
                        Console.WriteLine("Invalid number!");
                        
                    }
                    else
                    {
                        if (intNumber % 2 == 0)
                        {
                            Console.WriteLine($"Even number entered: {number}");
                            break;
                        }
                        Console.WriteLine("Invalid number!");
                    }
            }



        }
    }
}
