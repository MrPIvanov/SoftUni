using System;

namespace _09_MelrahShake
{
    public class StartUp
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (pattern.Length > 0)
            {
                if (text.IndexOf(pattern) >= 0 && text.LastIndexOf(pattern) >= 0 && text.IndexOf(pattern) != text.LastIndexOf(pattern))
                {
                    Console.WriteLine("Shaked it.");

                    text = text.Remove(text.IndexOf(pattern), pattern.Length);
                    text = text.Remove(text.LastIndexOf(pattern), pattern.Length);

                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    break;
                }


            }

            Console.WriteLine("No shake.");
            Console.WriteLine(text);
        }
    }
}