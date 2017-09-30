using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int curePatients = 0;
            int notCuredPatients = 0;
            int doctors = 7;

            for (int i = 1; i <= period; i++)
            {
                int dailyPatients = int.Parse(Console.ReadLine());

                if (i%3==0&&notCuredPatients>curePatients)
                {
                    doctors++;
                }

                if (dailyPatients>doctors)
                {
                    notCuredPatients = notCuredPatients + dailyPatients - doctors;
                    curePatients += doctors;
                }

                else 
                {
                    curePatients = curePatients + dailyPatients;
                }


            }

            Console.WriteLine($"Treated patients: {curePatients}.");
            Console.WriteLine($"Untreated patients: {notCuredPatients}.");

        }
    }
}
