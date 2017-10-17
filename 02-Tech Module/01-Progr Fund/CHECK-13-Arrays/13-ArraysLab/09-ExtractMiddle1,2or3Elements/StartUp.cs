namespace _09_ExtractMiddle1_2or3Elements
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');

            if (numbers.Length==1)
            {
                Console.WriteLine($"{{ {numbers[0]} }}");
            }

            else if (numbers.Length%2==0)
            {
               
                while (numbers.Length>2)
                {
                   numbers = numbers.Skip(1).ToArray();
                   numbers= numbers.Reverse().ToArray();
                }

                Console.WriteLine($"{{ {numbers[0]}, {numbers[1]} }}");

            }
            else
            {
                while (numbers.Length>3)
                {

                    numbers = numbers.Skip(1).ToArray();
                    numbers = numbers.Reverse().ToArray();
                }

                Console.WriteLine($"{{ {numbers[0]}, {numbers[1]}, {numbers[2]} }}");


            }

        }
    }
}