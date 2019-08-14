using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_MorseCodeUpgrad
{
    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split('|').ToList();
            var wordTotal = 0;
            bool isSame = false;

            foreach (var word in text)
            {
                for (int i = 0; i < word.Length-1; i++)
                {
                    if (isSame)
                    {
                        if (word[i] == word[i + 1])
                        {
                            wordTotal++;
                        }
                        else
                        {
                            isSame = false;
                        }

                    }
                    else
                    {
                        if (word[i] == word[i + 1])
                        {
                            isSame = true;
                            wordTotal += 2;                            
                        }
                    }

                    if (word[i] == '0')
                    {
                        wordTotal += 3;
                    }
                    else
                    {
                        wordTotal += 5;
                    }
                }

                if (word[word.Length-1] == '0')
                {
                    wordTotal += 3;
                }
                else
                {
                    wordTotal += 5;
                }
                Console.Write(Convert.ToChar(wordTotal));
                wordTotal = 0;
                isSame = false;
            }
            

        }
    }
}