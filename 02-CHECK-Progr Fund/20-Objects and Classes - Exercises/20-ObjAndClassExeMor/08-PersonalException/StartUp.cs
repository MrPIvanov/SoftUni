using System;

namespace _08_PersonalException
{
    public class StartUp
    {
        public static void Main()
        {
            int input;
            while (true)
            {

                try
                {
                    if ((input = int.Parse(Console.ReadLine())) >= 0)
                    {
                        Console.WriteLine(input);
                    }
                    else
                    {

                        throw new MyExeption();
                    }
                }
                catch (MyExeption ex)
                {

                    Console.WriteLine(ex.Message);
                    break;
                }

            }


        }
    }

    public class MyExeption : Exception
    {
        public MyExeption() : base("My first exception is awesome!!!")
        {

        }

    }
}