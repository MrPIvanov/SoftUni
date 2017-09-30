using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _13_1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Pls enter the date you are born: ");

            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);


           // string data = Console.ReadLine();
          //  DateTime newdata = DateTime.ParseExact(data, "dd-MM-yyyy", CultureInfo.InvariantCulture);    //i gore ti trqbva               !!!!!
                                                                                                           //using System.Globalization;    !!!!!
            Console.WriteLine(data.AddDays(999).ToString("dd-MM-yyyy"));

            Console.ReadLine();
        }
    }
}
