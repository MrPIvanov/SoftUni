using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_SMStype
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfChars = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfChars; i++)
            {

                string curentInput = Console.ReadLine();

                if (curentInput=="0")
                {
                    Console.Write(" ");
                    continue;
                }

                int curentLenght = curentInput.Length;

                string endChar = curentInput.Substring(curentInput.Length -1);

                int curentEndNumber = int.Parse(endChar);


                int offSet = (curentEndNumber-2)*3;

                if (curentEndNumber==8||curentEndNumber==9)
                {
                    offSet++;
                }

                int letterIndex = offSet + curentLenght - 1+97;

                Console.Write((char)letterIndex);
            }

        }
    }
}
