using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_money
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberBitCoin = double.Parse(Console.ReadLine());
            double numberChinies = double.Parse(Console.ReadLine());
            double numberComision = double.Parse(Console.ReadLine());

            double bitcoinLeva = numberBitCoin * 1168;
            double chiniesdolars = numberChinies*0.15;
            double chiniesLeva = chiniesdolars * 1.76;
            double allValue = (bitcoinLeva + chiniesLeva) / 1.95;
            double comision = numberComision / 100*allValue;





            Console.WriteLine(Math.Round(allValue - comision, 2));
            Console.ReadLine();



        }
    }
}
