using System;

namespace _03_KarateStrings
{
    public class StartUp
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var remainingCharsToDelete = 0;
            var result = "";
            bool isPunchReached = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '>')
                {
                    isPunchReached = true;
                }
                
                if (isPunchReached)
                {
                    if (text[i] == '>')
                    {
                        remainingCharsToDelete += int.Parse(text[i + 1].ToString());
                        result += text[i];
                        continue;
                    }

                    if (remainingCharsToDelete > 0)
                    {
                        remainingCharsToDelete--;
                        continue;
                    }
                    
                    else
                    {
                        result += text[i];

                    }
                }
                else
                {
                    result += text[i];
                }
            }

            Console.WriteLine(result);


        }
    }
}