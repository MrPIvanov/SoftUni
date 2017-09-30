using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_vowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int loops = text.Length;
            int result = 0;

            for (int i = 0; i < loops; i++)
            {
                char letter = text[i];

                switch (letter)
                {
                    case 'a':
                        result += 1;
                        break;
                    case 'e':
                        result += 2;
                        break;
                    case 'i':
                        result += 3;
                        break;
                    case 'o':
                        result += 4;
                        break;
                    case 'u':
                        result += 5;
                        break;
                }

            }

            Console.WriteLine(result);

        }
    }
}
