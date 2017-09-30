using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_wordPlural
{
    class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine().ToLower();

            bool endCharY = word.EndsWith("y");
            bool endCharO = word.EndsWith("o");
            bool endCharS = word.EndsWith("s");
            bool endCharX = word.EndsWith("x");
            bool endCharZ = word.EndsWith("z");
            bool endCharH = word.EndsWith("h");



            if (endCharY)
            {
                string result = word.Remove(word.Length-1,1);
                Console.WriteLine($"{result}ies");
            }

            else if (endCharO||endCharS||endCharX||endCharZ)
            {
                Console.WriteLine($"{word}es");
            }

            else if (endCharH)
            {
                string newWord = word.Remove(word.Length-1,1);

                bool endCharCH = newWord.EndsWith("c");
                bool endCharSH = newWord.EndsWith("s");

                if (endCharCH||endCharSH)
                {
                    Console.WriteLine($"{word}es");
                }

            }

            else
            {
                Console.WriteLine($"{word}s");
            }


        }
    }
}
